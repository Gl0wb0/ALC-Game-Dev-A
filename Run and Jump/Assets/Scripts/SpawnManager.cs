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
    
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", repeatDelay, startDelay);
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.GameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); 
        }
        
    }
}
