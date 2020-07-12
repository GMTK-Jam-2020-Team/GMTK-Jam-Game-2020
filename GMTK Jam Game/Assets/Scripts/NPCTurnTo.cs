using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NPCTurnTo : MonoBehaviour
{
    public List<GameObject> npcComponents = new List<GameObject>();


    public Transform player;

    public bool invertForward = false;

    public void TurnTo(Transform target, Transform toLook)
    {
        Vector3 temp = toLook.eulerAngles;   
        toLook.LookAt(target);

        toLook.eulerAngles = new Vector3(temp.x, toLook.eulerAngles.y - 180.0f, temp.z);
    }

    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    
    void Update()
    {
        foreach (GameObject obj in npcComponents)
        {
            TurnTo(player, obj.transform);
        }
    }
}
