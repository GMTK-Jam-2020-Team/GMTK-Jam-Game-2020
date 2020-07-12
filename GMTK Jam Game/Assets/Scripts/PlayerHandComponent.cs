using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

[System.Serializable]
public struct Hand
{
    public PlayerHandComponent ownerPHC;

    public GameObject gameObject;
    public Transform pivot;

    public GameObject holding;

    public Bounds2D movementBounds;
    public float lerpRate;

    public float grabRayLimit;

    public HandState state;

    public Animator animator;

    public void Update(Vector2 inputPos)
    {
        Vector3 newPos = inputPos * movementBounds;
        gameObject.transform.localPosition = Vector3.Lerp(newPos, gameObject.transform.localPosition, lerpRate);

        Vector3 handDirection = pivot.localPosition - gameObject.transform.localPosition;
        gameObject.transform.localRotation = Quaternion.FromToRotation(Vector3.down, handDirection.normalized);

        UpdateAnimator();

        if (holding)
        {
            EdibleComponent ec;
            if(holding.TryGetComponent(out ec))
            {
                ec.TryEat(DistToMouth());
            }
        }
    }

    public float DistToMouth()
    {
        return Vector3.Distance(gameObject.transform.position, ownerPHC.mouthPos.position);
    }

    public void UpdateAnimator()
    {
        if (state == HandState.HandState_Closed)
        {
            animator.SetBool("Grabbing", true);
        }
        else if (state == HandState.HandState_Open)
        {
            animator.SetBool("Grabbing", false);
        }
    }

    public void OnGrab(Vector3 rayOrigin)
    {
        int layerMask = LayerMask.GetMask("Grabbable");
        Ray ray = new Ray(rayOrigin, gameObject.transform.position - rayOrigin);
        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(ray, out hit, grabRayLimit, layerMask))
        {
            holding = hit.collider.gameObject;

            GrabbableComponent grabbableComponent;
            if (holding.TryGetComponent(out grabbableComponent))
            {
                grabbableComponent.OnGrab(this);
            }
            else
            {
                Debug.Log("Grabbed an object without a GrabbableComponent! Doublecheck that " + hit.collider.name + " has a GrabbableComponent attached.");
            }
        }

    }

    public void OnRelease()
    {
        if(holding)
        {
            GrabbableComponent grabbableComponent;
            if (holding.TryGetComponent(out grabbableComponent))
            {
                grabbableComponent.OnRelease(this);
            }
            else
            {
                Debug.Log("Released an object without a GrabbableComponent! Doublecheck that " + holding.name + " has a GrabbableComponent attached.");
            }

            holding = null;
        }
    }
}

public enum HandState
{
    HandState_Open,
    HandState_Closed
}

public class PlayerHandComponent : MonoBehaviour
{
    public Hand leftHand;
    public Hand rightHand;

    public Transform mouthPos;

    private Camera playerCamera;

    // Input
    GameControls inputActions;

    public bool disableLook;

    private Vector2 leftHandPos;
    private Vector2 rightHandPos;

    public Vector2[] GetHandPositions() { return new Vector2[]{ leftHandPos, rightHandPos }; }

    private void Awake()
    {
        //TODO: Make this *not* rely on the MainCamera just in case somebody de-tags it???
        playerCamera = Camera.main;

        inputActions = new GameControls();

        // Left
        inputActions.ZG_Main.LeftHand.performed += ctx => leftHandPos = ctx.ReadValue<Vector2>();
        inputActions.ZG_Main.LeftHand.canceled  += ctx => leftHandPos = Vector2.zero;

        inputActions.ZG_Main.LeftGrab.started   += ctx => leftHand.OnGrab(playerCamera.transform.position);
        inputActions.ZG_Main.LeftGrab.performed += ctx => leftHand.state = HandState.HandState_Closed;
        inputActions.ZG_Main.LeftGrab.canceled  += ctx => leftHand.state = HandState.HandState_Open;
        inputActions.ZG_Main.LeftGrab.canceled  += ctx => leftHand.OnRelease();

        // Right
        inputActions.ZG_Main.RightHand.performed += ctx => rightHandPos = ctx.ReadValue<Vector2>();
        inputActions.ZG_Main.RightHand.canceled  += ctx => rightHandPos = Vector2.zero;

        inputActions.ZG_Main.RightGrab.started   += ctx => rightHand.OnGrab(playerCamera.transform.position);
        inputActions.ZG_Main.RightGrab.performed += ctx => rightHand.state = HandState.HandState_Closed;
        inputActions.ZG_Main.RightGrab.canceled  += ctx => rightHand.state = HandState.HandState_Open;
        inputActions.ZG_Main.RightGrab.canceled  += ctx => rightHand.OnRelease();

        inputActions.ZG_Main.DisableLook.performed += ctx => disableLook = true;
        inputActions.ZG_Main.DisableLook.canceled  += ctx => disableLook = false;

        leftHand.ownerPHC = this;
        rightHand.ownerPHC = this;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        leftHand.Update(leftHandPos);
        rightHand.Update(rightHandPos);
    }
}
