﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets; 
    
    //Time between objects that are created
    public float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;

    private int score; 

    

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnTarget());
        score = 0; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Every second, random object is selected and created in the game
    IEnumerator SpawnTarget() {

        while (true) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);


        }
    }

    public void UpdateScore(int scoreToAdd) {

        score += scoreToAdd; 
        scoreText.text = "Score: " + score; 

    }


}
