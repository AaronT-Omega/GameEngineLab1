using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;


    private float elapsedTime = 0f;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public int currentScore = 0;

    public CircleSpawner spawner;
    


    void Start()
    {
        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: " + DateTime.Now);


        UpdateScoreDisplay();
        TargetClick target = spawner.Spawn();
        
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        DisplayTime(elapsedTime);

        spawner.randomPos = new Vector3(UnityEngine.Random.Range(-7f, 7f), UnityEngine.Random.Range(-3f, 3f), 0);

    }
    void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        TimeSpan timeDifference =
        _sessionEndTime.Subtract(_sessionStartTime);
        Debug.Log(
        "Game session ended @: " + DateTime.Now);
        Debug.Log(
        "Game session lasted: " + timeDifference);
    }
    
    public void AddPoints(int pointsToAdd)
    {
        currentScore += pointsToAdd;
        UpdateScoreDisplay();
    }
    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore.ToString();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; // To ensure the timer shows 00:00 at the end, not -00:01

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (timerText != null)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

}

