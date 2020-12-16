using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Rigidbody playerRb; 
    public float speed = 5.0f; 
    private GameObject focalPoint; 
    public bool hasPowerup; 
    private float PowerupStrength = 15.0f;
    public GameObject PowerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
       playerRb = GetComponent<Rigidbody>(); 
       focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * forwardInput * speed);
        PowerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true; 
            Destroy(other.gameObject); 
            StartCoroutine(PowerupCountdownRoutine());
            PowerupIndicator.gameObject.SetActive(true); 
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        PowerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>(); 
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

          
            Debug.Log("Player collided with" + collision.gameObject + " with poweup set to " + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * PowerupStrength, ForceMode.Impulse);
        }

    }
}
