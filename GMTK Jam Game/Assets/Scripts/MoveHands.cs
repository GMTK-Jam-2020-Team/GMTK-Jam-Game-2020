using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Hand
{
    public GameObject gameObject;
    public Transform pivot;

    public Bounds2D movementBounds;
    public float lerpRate;

    public HandState state;

    public void Update(Vector2 inputPos)
    {
        Vector3 newPos = inputPos * movementBounds;
        gameObject.transform.localPosition = Vector3.Lerp(newPos, gameObject.transform.localPosition, lerpRate);

        Vector3 handDirection = pivot.localPosition - gameObject.transform.localPosition;
        gameObject.transform.localRotation = Quaternion.FromToRotation(Vector3.down, handDirection.normalized);
    }
}

public enum HandState
{
    HandState_Open,
    HandState_Closed
}

public class MoveHands : MonoBehaviour
{
    public Hand leftHand;
    public Hand rightHand;

    public float handDistMod;

    // Input
    GameControls inputActions;

    private Vector2 leftHandPos;
    private Vector2 rightHandPos;

    private void Awake()
    {
        inputActions = new GameControls();

        // Left
        inputActions.ZG_Main.LeftHand.performed += ctx => leftHandPos = ctx.ReadValue<Vector2>();
        inputActions.ZG_Main.LeftHand.canceled  += ctx => leftHandPos = Vector2.zero;
        
        inputActions.ZG_Main.LeftGrab.performed += ctx => leftHand.state = HandState.HandState_Closed;
        inputActions.ZG_Main.LeftGrab.canceled  += ctx => leftHand.state = HandState.HandState_Open;

        // Right
        inputActions.ZG_Main.RightHand.performed += ctx => rightHandPos = ctx.ReadValue<Vector2>();
        inputActions.ZG_Main.RightHand.canceled  += ctx => rightHandPos = Vector2.zero;

        inputActions.ZG_Main.RightGrab.performed += ctx => rightHand.state = HandState.HandState_Closed;
        inputActions.ZG_Main.RightGrab.canceled  += ctx => rightHand.state = HandState.HandState_Open;

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
