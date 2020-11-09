using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 10;
    private float LeftBound = -15; 
    // Start is called before the first frame update
    void Start()
    {
       playerControllerScript = GameObject.Find("Player").GetComponent <PlayerController>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if(playerControllerScript.GameOver == false);
       {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
       }
       
       if(Transform.position.x < LeftBound && GameObject.CompareTag("Obstacle"))
       {
        Destroy(GameObject);
       }
    }
}
