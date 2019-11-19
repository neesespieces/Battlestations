using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When game object collides with something, destroy the gameObject we're in
    // And also destroy the thing it collided with
    private void OnTriggerEnter(Collider other) {

        Destroy(gameObject);
        Destroy(other.gameObject); 


    }
}
