using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public float topBounds = 35.05f;
    public float lowerBounds = -15.0f;
    
    // Update is called once per frame
    void Update()
    {
    //if the game object goes past the topbounds limit it will be deleted 
      if(transform.position.z > topBounds) 
      {
        Destroy(gameObject);
      }
      
    //if the game object goes past the lowerbounds limit it will be deleted
      else if(transform.position.z < lowerBounds) 
      {
        Destroy(gameObject);
        Debug.Log("GAME OVER");
      }
    }
}
