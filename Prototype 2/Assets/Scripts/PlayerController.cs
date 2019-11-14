using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10.0f;

    private float xRange = 10.0f;

    // dragging a prefab into here from Unity so that computer creating instance
    //not trying to create the object already in your scene (it would try to do this if you dragged from hierarchy)
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If player goes outside range of x values, position gets reset to keep them in bounds
        if (transform.position.x < -xRange) {

            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }

         if (transform.position.x > xRange) {

            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)) {

            Instantiate(projectilePrefab, this.transform.position, projectilePrefab.transform.rotation); 
        }


        
    }
}
