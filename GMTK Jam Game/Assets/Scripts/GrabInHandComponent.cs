using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabInHandComponent : GrabbableComponent
{
    Transform hand;

    public Vector3 positionOffset;
    public Vector3 rotationalOffset;
    public Vector3 scaleOverride = Vector3.one;

    private Vector3 scaleOriginal;

    private void Start()
    {
        scaleOriginal = transform.localScale;
    }

    public override void OnGrab(Hand grabber)
    {
        hand = grabber.gameObject.transform;
        transform.localScale = scaleOverride;
    }

    public override void OnRelease(Hand releaser)
    {
        hand = null;
        transform.localScale = scaleOriginal;
    }

    private void MoveToHandTransform()
    {
        if (hand)
        {
            transform.position = hand.position + hand.rotation * positionOffset;
            transform.rotation = hand.rotation * Quaternion.Euler(rotationalOffset);
        }
    }

    private void LateUpdate()
    {
        MoveToHandTransform();
    }
}
