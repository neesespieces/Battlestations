using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 


public class GameManager : MonoBehaviour
{

    public List<GameObject> targets; 
    
    //Time between objects that are created
    public float spawnRate = 1.0f;

    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI gameOverText; 

    private int score; 

    public bool isGameActive; 

    public Button restartButton; 

    public GameObject titleScreen;

    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Every second, random object is selected and created in the game
    IEnumerator SpawnTarget() {

        while (isGameActive) {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);


        }
    }

    public void UpdateScore(int scoreToAdd) {

        score += scoreToAdd; 
        scoreText.text = "Score: " + score; 

    }

    public void GameOver() {

        restartButton.gameObject.SetActive(true); 
        gameOverText.gameObject.SetActive(true); 
        isGameActive = false; 
    }

    public void RestartGame() {
        
        //Reloading the last active scene, which you get by name
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void StartGame(int difficulty) {

        isGameActive = true; 
        score = 0; 
        spawnRate = (spawnRate / difficulty); 
        
        StartCoroutine(SpawnTarget());
        UpdateScore(0);

        titleScreen.gameObject.SetActive(false); 
        
    }

}
