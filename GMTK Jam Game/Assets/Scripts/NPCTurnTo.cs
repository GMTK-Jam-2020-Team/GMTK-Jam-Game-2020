﻿using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NPCTurnTo : MonoBehaviour
{
    public GameObject npcTop;
    public GameObject npcBottom;

    public Transform player;

    public bool invertForward = false;

    public void TurnTo(Transform target, Transform toLook)
    {
        Debug.Log(npcTop.transform.forward);
        Debug.Log(npcBottom.transform.forward);

        Vector3 temp = toLook.eulerAngles;   
        toLook.LookAt(target);

        toLook.eulerAngles = new Vector3(temp.x, toLook.eulerAngles.y - 180.0f, temp.z);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TurnTo(player, npcTop.transform);
        TurnTo(player, npcBottom.transform);
    }
}