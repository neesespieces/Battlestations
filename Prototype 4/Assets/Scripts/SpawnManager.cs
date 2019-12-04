using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float range = 9;
    public GameObject enemyPrefab; 
    void Start()
    {
        Vector3 randomPos = GenerateSpawnPos(); 
        Instantiate(enemyPrefab, randomPos, enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPos() {
        
        float spawnPosX = Random.Range(-range, range);
        float spawnPosZ = Random.Range(-range, range);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos; 
    }
}
