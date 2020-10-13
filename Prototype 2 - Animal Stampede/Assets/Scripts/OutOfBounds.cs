using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public float topBounds = -15;
    public float lowerBounds = 35;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //if the game object goes past the topbounds limit it will be deleted 
      if(transform.position.z < topBounds) 
      {
        Destroy(gameObject);
      }
      
    //if the game object goes past the lowerbounds limit it will be deleted
      if(transform.position.z < lowerBounds) 
      {
        Destroy(gameObject);
      }
    }
}
