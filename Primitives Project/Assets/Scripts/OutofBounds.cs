using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float XBounds = 1000;
    public float YBounds = 1000;
    private Rigidbody bulletRb; 
    
    // Update is called once per frame

    void Start()
        {
            bulletRb = GetComponent<Rigidbody>();
        }
    
    void Update()
    {
    //if the game object goes past the topbounds limit it will be deleted 
      if(transform.position.z > YBounds) 
      {
        Destroy(gameObject);
      }
       else if(transform.position.x > XBounds) 
      {
        Destroy(gameObject);
      }
    } 
}
