using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct MoveParams
{
    public float moveSpeed;
    public float moveSize;
    public float moveInteral;
}

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerCameraComponent))]
public class PlayerMoveComponent : MonoBehaviour
{
    private CharacterController cc;
    private PlayerCameraComponent pcc;

    public MoveParams moveParams;

    private float prevMoveTime;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        pcc = GetComponent<PlayerCameraComponent>();
    }

    private void Update()
    {
        cc.SimpleMove(pcc.forward * moveParams.moveSpeed);
    }
}
