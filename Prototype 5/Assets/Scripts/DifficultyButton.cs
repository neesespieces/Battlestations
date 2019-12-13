using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DifficultyButton : MonoBehaviour
{

    private Button button; 
    private GameManager gameManager; 
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>(); 
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        // When button is clicked, computer will listen for it, and then call set difficulty
        button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty() {

        gameManager.StartGame();


    }
}
