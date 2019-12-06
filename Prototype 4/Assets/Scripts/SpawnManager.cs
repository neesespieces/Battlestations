﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float range = 9;
    public GameObject enemyPrefab; 

    public int enemyCount;

    public int waveNumber = 1;

    public GameObject powerupPrefab; 
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length; 

        if (enemyCount == 0) {

            waveNumber++; 
            SpawnEnemyWave(waveNumber); 
            Instantiate(powerupPrefab, GenerateSpawnPos(), powerupPrefab.transform.rotation);
            
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn) {
        
        for (int i = 0; i < enemiesToSpawn; i++) {

            Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
        
        }

    }

    private Vector3 GenerateSpawnPos() {
        
        float spawnPosX = Random.Range(-range, range);
        float spawnPosZ = Random.Range(-range, range);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos; 
    }
}
