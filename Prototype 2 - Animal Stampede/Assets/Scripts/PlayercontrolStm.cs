using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayercontrolStm : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    
    public GameObject foodProjectile;
    // Update is called once per frame
    void Update()
    {
      horizontalInput = Input.GetAxis("Horizontal"); 
      transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
      //constrains Players Movement to the left with negative xRange
      if(transform.position.x < -xRange)
      
      {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
      }
      
      //constrains Players Movement to the right by using xRange
      if(transform.position.x > xRange)
      {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
      }
      
      if(Input.GetKeyDown(KeyCode.Space))
      {
        Instantiate(foodProjectile, transform.position, foodProjectile.transform.rotation);
      }
    }
}
