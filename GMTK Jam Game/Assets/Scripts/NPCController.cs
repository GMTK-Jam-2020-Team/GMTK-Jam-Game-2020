using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NPCController: MonoBehaviour
{
    public GameObject npcHead;
    public GameObject npcBrain;
    private Vector3 headOrigPos;
    public List<GameObject> npcComponents = new List<GameObject>();

    public Transform player;

    private bool headOff = false;

    public void TurnTo(Transform target, Transform toLook)
    {
        Vector3 temp = toLook.eulerAngles;   
        toLook.LookAt(target);

        toLook.eulerAngles = new Vector3(temp.x, toLook.eulerAngles.y - 180.0f, temp.z);
    }

    void Start()
    {
        if (npcHead != null)
        {
            headOrigPos = npcHead.transform.position;
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    
    void Update()
    {
        //Turn each npc towards the player
        foreach (GameObject obj in npcComponents)
        {
            TurnTo(player, obj.transform);
        }

        TurnTo(player, npcHead.transform);
        if(npcBrain)
            TurnTo(player, npcBrain.transform);

        //Check if head has moved
        if (headOrigPos != npcHead.transform.position && !headOff)
        {
            headOff = true;
            npcBrain.SetActive(true);
        }
    }
}
