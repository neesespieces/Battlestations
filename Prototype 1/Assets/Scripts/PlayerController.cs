using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;    
    public float turnSpeed = 5; 
    public float horizontalInput; 
    public float forwardInput; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame, but Time.deltaTime transitions it to seconds btwn frames
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward, meaning changing one z axis 
        // forward is (0,0,1) vector, assuming right is (1, 0, 0)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); 

    }
}
