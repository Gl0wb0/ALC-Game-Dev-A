﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    //sets up the delay from the dogs initial fire
    private float DogDelay = .5f;
    //sets the start fire rate
    private float DogFire = 1.0f;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > DogFire)
        {
        
            DogFire = Time.time + DogFire;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
