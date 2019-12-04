using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody enemyRb;
    private GameObject player;
    public float speed = 3.0f;
    void Start()
    {
        // Finding references to enemy and rigid body
        enemyRb = GetComponent<Rigidbody>(); 
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - this.transform.position).normalized;
        enemyRb.AddForce( lookDirection * speed); 
    }
}
