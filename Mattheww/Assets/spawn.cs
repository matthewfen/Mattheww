using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] alien;

    private float timeToSpawn = 4f;

    public float timeBetweenWaves = 4f;

    void Start()
    {

    }


    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex1 = Random.Range(0, alien.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(alien[randomIndex1], spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
