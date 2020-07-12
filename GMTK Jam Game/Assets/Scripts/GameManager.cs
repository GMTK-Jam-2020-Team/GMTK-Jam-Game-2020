using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    HungerBar playerHunger;
    PlayerHandComponent phc;

    public AudioSource backgroundMusic;

    public GameObject gameOverScreen;

    bool playerActive;

    private void Start()
    {
        playerHunger = GetComponent<HungerBar>();
        phc = GetComponent<PlayerHandComponent>();

        ActivatePlayer();
    }

    private void Update()
    {
        // PSA, don't check stuff every frame. It's more efficient to have an OnDie() event that's called by the hunger bar when it is reduced below 0
        if(playerHunger.CheckDead())
        {

        }
    }

    public void ActivatePlayer()
    {
        if(!playerActive)
        {
            backgroundMusic.Play();
            //phc.Activate();
            playerActive = true;

            SetGameOver(false);
        }
    }

    public void DeactivatePlayer()
    {
        if(playerActive)
        {
            backgroundMusic.Stop();
            playerActive = false;

            if(playerHunger.CheckDead())
            {
                SetGameOver(true);
            }
        }
    }

    public void SetGameOver(bool value)
    {
        gameOverScreen.SetActive(value);
    }
}
