using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerHandComponent))]
public class PlayerCameraComponent : MonoBehaviour
{
    private PlayerHandComponent phc;

    public Vector3 lookForward
    {
        get => headRoot.forward;
    }

    public Vector3 forward
    {
        get => Vector3.ProjectOnPlane(headRoot.forward, Vector3.up).normalized;
    }

    public Transform headRoot;

    public Vector2 lookThreshold;
    public float lookSpeed;
    public Vector2 yLookLimits;

    private Vector2 currentAngles;

    private void Start()
    {
        phc = GetComponent<PlayerHandComponent>();
    }

    private Vector2 GetLookInput()
    {
        var handPositions = phc.GetHandPositions();
        Vector2 lookInput = Vector2.zero;

        foreach (Vector2 handPos in handPositions)
        {
            for (int i = 0; i < 2; i++)
            {
                if (Mathf.Abs(handPos[i]) >= lookThreshold[i])
                {
                    lookInput[i] += Mathf.Sign(handPos[i]);
                }
            }
        }

        return lookInput;
    }

    private void Update()
    {
        if(!phc.disableLook)
        {
        var lookInput = GetLookInput();
        currentAngles += lookInput * lookSpeed;
        currentAngles.y = Mathf.Clamp(currentAngles.y, yLookLimits.x, yLookLimits.y);
        headRoot.localRotation = Quaternion.Euler(-currentAngles.y, currentAngles.x, 0);
        }
    }
}
