using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (30, 0, 0);
    
    //makes it take a second to spawn the repeats at a constant rate
    private float startDelay = 2;
    private float repeatDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", repeatDelay, startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); 
    }
}
