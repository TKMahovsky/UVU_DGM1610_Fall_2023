using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    private float spawnRangeX = 17f;
    private float spawnPosZ = 10f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //Random spawn position
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Picks random UFO from array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawns indexed UFO from array at random X location
    }
}
