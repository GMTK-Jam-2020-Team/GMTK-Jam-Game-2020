using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class HungerBar : MonoBehaviour
{
    public ProgressBar hungerBar;
    public float timeToHungerLoss = 0.3f;
    public float brainToHungerGain = 20.0f;
    public Vector3 lastPos;

    private void Start()
    {
        lastPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckMovement())
        {
            LoseHunger();
        }

        lastPos = gameObject.transform.position;
    }

    bool CheckMovement()
    {
        //Only lose hunger when moving
        float movementMag = Vector3.Magnitude(gameObject.transform.position - lastPos);

        return (movementMag > 0);
    }

    public bool CheckDead()
    {
        return (hungerBar.current <= 0.0f);
    }

    void LoseHunger()
    {
        //Hungerloss is a conversion from time to hunger loss
        float hungerLoss = Time.deltaTime * timeToHungerLoss;
        
        hungerBar.current -= hungerLoss;
    }

    public void FillHunger()
    {
        float hungerGain = brainToHungerGain;
        hungerBar.current += hungerGain;
    }
}
