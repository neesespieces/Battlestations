using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed = 6.0f;

    public bool hasPowerup = false;

    private GameObject focalPoint; 

    private float powerUpStrength = 10.0f; 

    private float waitTime = 5;

    public GameObject powerupIndicator; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        focalPoint = GameObject.Find("Focal Point"); 

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); 
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);
        powerupIndicator.transform.position = this.transform.position + new Vector3(0, -0.5f, 0);
    }


    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Powerup")) {

            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupTimer());
        }

    }

      IEnumerator PowerupTimer() {

        yield return new WaitForSeconds(waitTime);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }



    private void OnCollisionEnter(Collision collision) {

        if(collision.gameObject.CompareTag("Enemy") && hasPowerup) {

            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - this.transform.position; 

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
