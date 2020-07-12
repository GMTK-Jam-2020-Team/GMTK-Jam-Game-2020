using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GrabbableComponent : MonoBehaviour
{
    public abstract void OnGrab(Hand grabber);

    public abstract void OnRelease(Hand releaser);
}
