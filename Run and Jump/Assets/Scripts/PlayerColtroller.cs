using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColtroller : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    //makes sure the player is on the ground
    public bool isOnGround = true;
    
    // Start is called before the first frame update
    void Start()
    {
      //getting the component from the players rigidbody
      playerRb = GetComponent<Rigidbody>();
      //acsesses the physics class in unity and multiplies its gravity buy our own modifier
      Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
       //checks for if the up key is pressed it will jump & if its on the ground
       if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
       {
         playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
         isOGround = False:
       } 
    }
    
    //once the box collider hits the floor the player can jump again
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = ;rue;
    }
}
