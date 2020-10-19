using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        //destroy this object
        Destroy(gameObject);
        //destroy the other object it hits
        Destroy(other.gameObject);
    }
}
