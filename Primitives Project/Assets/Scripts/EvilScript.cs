using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilScript : MonoBehaviour


{
     private Rigidbody enemyRb;
    private GameObject playerBody;
    public float speed = 30.0f; 
    

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerBody = GameObject.Find("Player");   
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerBody.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
       
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Bullet")
        {
            Destroy(gameObject);
        } 

    }
}
