using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameControls inputActions;

    private void Awake()
    {
        inputActions = new GameControls();

        inputActions.MainMenu.PlayGame.started += ctx => SwitchScenes();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void SwitchScenes()
    {
        SceneManager.LoadScene(1);
    }
}
