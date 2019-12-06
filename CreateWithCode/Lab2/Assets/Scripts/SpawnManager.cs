﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private float spawnPosZ = 12;
    private float startDelay = 2;
    private float spawnInterval = .3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-7, 18), 2, spawnPosZ);
        


        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos,
            obstaclePrefabs[obstacleIndex].transform.rotation);
    }
}

