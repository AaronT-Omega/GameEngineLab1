using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private float timeLimit = 30f; // Time Limit for game
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
    // Text innitlization to be used and edited later

    public int currentScore = 0;
    // Int var to keep track of score

    public CircleSpawner redSpawn;
    public CircleSpawner orangeSpawn;
    // Sets up target/circle spawners


    private void Start()
    {
    
        UpdateScoreDisplay();
        // Sets up Score Display text


        //TargetClick target = spawner.Spawn(); 
        // Mainly was based of off the lecture slides, but this caused the red circle to spawn early.
        
    }

    private void Update()
    {
        timeLimit -= Time.deltaTime;
        DisplayTime(timeLimit);
        // Creates a countdown and calls a function to display said countdown

        redSpawn.randomPos = new Vector3(UnityEngine.Random.Range(-7f, 7f), UnityEngine.Random.Range(-3f, 3f), 0);
        orangeSpawn.randomPos = new Vector3(UnityEngine.Random.Range(-7f, 7f), UnityEngine.Random.Range(-3f, 3f), 0);
        // Randomly generates spawn positions for both Red and Orange targets

        GameOver();
        // Calls the Game Over function and is checked every frame

    }

    public void AddPoints(int pointsToAdd) // Used to add points to the score and display said score everytime new points are earned
    {
        currentScore += pointsToAdd;
        UpdateScoreDisplay();
    }


    void UpdateScoreDisplay() // Basic function to record the score in the text
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }

    void DisplayTime(float timeToDisplay) // Sets up a timer display in a 00:00 format
    {
        timeToDisplay += 1; // To ensure the timer shows 00:00 at the end, not -00:01

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (timerText != null)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    void GameOver() // Pauses the game once time is up and enables the Game Over text
    {
        if(timeLimit <= 0f)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Over");
            gameOverText.gameObject.SetActive(true);

        }
    }
   

}

