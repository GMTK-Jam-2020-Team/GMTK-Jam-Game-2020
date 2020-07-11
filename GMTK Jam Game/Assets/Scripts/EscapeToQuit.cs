using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeToQuit : MonoBehaviour
{
    GameControls inputActions;

    private void Awake()
    {
        inputActions = new GameControls();
        inputActions.EscapeToQuit.Quit.performed += ctx => Application.Quit();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
