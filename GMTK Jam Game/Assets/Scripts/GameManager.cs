using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    HungerBar playerHunger;
    PlayerHandComponent phc;
    PlayerMoveComponent pmc;

    public AudioSource backgroundMusic;

    public GameObject gameOverScreen;

    bool playerActive;
    public float gameoverDelay = 1.0f;

    private float timeAtGameover;

    private void Start()
    {
        playerHunger = GetComponent<HungerBar>();
        phc = GetComponent<PlayerHandComponent>();
        pmc = GetComponent<PlayerMoveComponent>();

        ActivatePlayer();
    }

    private void Update()
    {
        if (!playerActive)
        {
            if(Time.time - timeAtGameover > gameoverDelay)
            {
                ToMainMenu();
            }
        }
        // PSA, don't check stuff every frame. It's more efficient to have an OnDie() event that's called by the hunger bar when it is reduced below 0
        else if(playerHunger.CheckDead())
        {
            DeactivatePlayer();
        }
    }

    public void ActivatePlayer()
    {
        if(!playerActive)
        {
            backgroundMusic.Play();
            //phc.Activate();

            SetGameOver(false);

            pmc.freezeWalk = false;

            playerActive = true;
        }
    }

    public void DeactivatePlayer()
    {
        if(playerActive)
        {
            backgroundMusic.Stop();

            if(playerHunger.CheckDead())
            {
                SetGameOver(true);
            }

            pmc.freezeWalk = true;

            playerActive = false;
        }
    }

    public void SetGameOver(bool value)
    {
        gameOverScreen.SetActive(value);
        timeAtGameover = Time.time;
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
