using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    //makes sure the player is on the ground
    public bool isOnGround = true;
    public bool gameOver = false; 

    private Animator playerAnim; 
    public ParticleSystem explosionParticle; 
    public ParticleSystem dirtParticle; 

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    
    // Start is called before the first frame update
    void Start()
    {
      //getting the component from the players rigidbody
      playerRb = GetComponent<Rigidbody>();
      //acsesses the physics class in unity and multiplies its gravity buy our own modifier
      Physics.gravity *= gravityModifier; 

      playerAnim = GetComponent<Animator>();

      playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       //checks for if the up key is pressed it will jump & if its on the ground
       if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
       {
         playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
         isOnGround = false;
         playerAnim.SetTrigger("Jump_trig");
         dirtParticle.Stop();
         playerAudio.PlayOneShot(jumpSound, 1.0f);
       } 
    }
    
    //once the box collider hits the floor the player can jump again
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play(); 
        }
        
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("GAME OVER");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 2);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f); 
        }
        
    }
}
