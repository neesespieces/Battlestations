using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb; 
    private float torqueRange = 10;

    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float xRange = 4;
    private float yPos = -4;


   
   
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>(); 

        // Objects sent flying up into air at random speed
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); 

        transform.position = RandomPos(); 

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {

        Destroy(this.gameObject);
    }

    //When the objects pass below a certain point, they hit a box collider that's a trigger
    // and when this happens, they are deleted from the scene
    private void OnTriggerEnter (Collider other) {

        Destroy(this.gameObject);

    }

    Vector3 RandomForce() {
        
        return Vector3.up * Random.Range(minSpeed, maxSpeed);

    }

    float RandomTorque() {
        
        return Random.Range(-torqueRange, torqueRange);

    }


    Vector3 RandomPos() {
         
         return new Vector3(Random.Range(-xRange, xRange), yPos);

    }
}
