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
    //Destroys objects that go outside of player's view 
    void Update()
    {
        // If cookie goes too far infront of player 
        if (transform.position.z > topSceneBound) {
            Destroy(this.gameObject); 
        }

        // If animal goes behind player, game over 
        else if (transform.position.z < bottomSceneBound) {
           
            Debug.Log("Game Over!");
            Destroy(this.gameObject); 
            
        }
    
    }
}
