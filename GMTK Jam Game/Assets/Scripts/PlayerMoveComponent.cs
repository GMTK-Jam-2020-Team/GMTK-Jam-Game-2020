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

    public bool freezeWalk = false;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
        pcc = GetComponent<PlayerCameraComponent>();
    }

    private void Update()
    {
        if (!freezeWalk)
        {
            cc.SimpleMove(pcc.forward * moveCurve.Evaluate(Time.time) * speedModifier);
        }
    }
}
