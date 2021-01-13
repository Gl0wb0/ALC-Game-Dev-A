using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private float Speed = 30; 
    private float NormalSpeed = 30;
    private float RunSpeed = 60;
    private float jumpForce = 25; 
    private float turnSpeed = 60; 
    private Rigidbody playerRb;
    private  float horizontalInput;
    private  float forwardInput;
    public bool isOnGround = true;
    public bool gameOver = false; 
    public bool isRunning = false;
     public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");

       forwardInput = Input.GetAxis("Vertical");
     
     
       transform.Translate(Vector3.forward * Time.deltaTime * Speed * forwardInput);
     
       transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
          
          
     if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
       {
         playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
         isOnGround = false;
       } 

     if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
       {
             isRunning = true;
             Speed = RunSpeed;

       }
        else 
        {
 
             isRunning = false;
             Speed = NormalSpeed;
        }
        
        if(Input.GetKeyDown(KeyCode.Q))
      {
        Instantiate(Bullet, transform.position, Bullet.transform.rotation);
      }

       }
   

      private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
  
  
   
}
