using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20f;
    private float spawnPosZ = 30f; 

    private float startDelay = 2; 
    private float spawnInterval = 1.5f; 
    
    void start()
    {
        SpawnRandAnimal(); 
        //makes it so the animals dont start pouring out
        InvokeRepeating("SpawnRandAnimal", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandAnimal()
    {
        //spawns a animal in a randome range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); 
            
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

