using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerCameraComponent))]
public class PlayerMoveComponent : MonoBehaviour
{
    private CharacterController cc;
    private PlayerCameraComponent pcc;

    public AnimationCurve moveCurve;
    public float speedModifier;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        pcc = GetComponent<PlayerCameraComponent>();
    }

    private void Update()
    {
        cc.SimpleMove(pcc.forward * moveCurve.Evaluate(Time.time) * speedModifier);
    }
}
