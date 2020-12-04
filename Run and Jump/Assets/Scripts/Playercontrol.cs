using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    // Access Modifier, Type name, Operator, Value
   private int speed = 20; 
   private  float turnSpeed = 50; 
    
   private  float horizontalInput;
   private  float forwardInput;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
     horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
     
     //Move the vehicle forwards based on forwardInput  
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     //Move the vehicle left and right base on horizontalInput
     transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
     
    }
}
