using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update

    private float topSceneBound = 30.0f;
    private float bottomSceneBound = -15.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topSceneBound) {
            Destroy(this.gameObject); 
        }

        else if (transform.position.z < bottomSceneBound) {
            Destroy(this.gameObject); 
            
        }
    
    }
}
