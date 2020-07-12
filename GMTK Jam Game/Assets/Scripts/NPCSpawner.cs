using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public float spawnRadius;
    public float timeToSpawn;
    float timer = 0.0f;
    public int spawnedNPCs = 0;
    public int spawnLimit;
    public List<GameObject> spawnables = new List<GameObject>();
    public List<GameObject> spawnPoints = new List<GameObject>();


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn && spawnedNPCs < spawnLimit)
        {
            timer = 0.0f;

            //Finds a range between 0 and the number of spawnable objects
            int toSpawn = Random.Range(0, spawnables.Count - 1);
            int whereSpawn = Random.Range(0, spawnPoints.Count - 1);
            Vector3 whereInDisk = (Random.insideUnitSphere * spawnRadius + spawnPoints[whereSpawn].transform.position) ;
            whereInDisk.y = spawnPoints[whereSpawn].transform.position.y;

            //Instantiate the game object
            Instantiate(spawnables[toSpawn], whereInDisk, Quaternion.identity);
            spawnedNPCs++;
        }
    }
}
