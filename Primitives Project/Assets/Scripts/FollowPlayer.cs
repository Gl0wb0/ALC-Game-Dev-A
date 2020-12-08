using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
public GameObject player;
private Vector3 offset = new Vector3(0, 10, -24);
    

    // Update is called once per frame
    void Update()
    {
        //makes the camera match the players movement and position
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}

