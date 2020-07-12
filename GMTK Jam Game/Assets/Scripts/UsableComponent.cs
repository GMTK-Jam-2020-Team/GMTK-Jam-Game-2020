using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UsableComponent : MonoBehaviour
{
    public abstract void OnUse(GameObject instigator);
}
