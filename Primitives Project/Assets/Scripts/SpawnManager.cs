using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab; 
    private float startDelay = .5f; 
    private float spawnInterval = 10f; 

    private float spawnPositionX = 600; 

    private float spawnPositionZ = 600;
    private Vector3 spawnPosition;

    
    void Start()
    {
        SpawnEnemy(); 
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }
   
    void SpawnEnemy()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), 80, spawnPositionZ);
        
        Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);

        Debug.Log("is spawning");

    }

    }

    

