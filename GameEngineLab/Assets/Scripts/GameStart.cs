using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/*
 * Was not able to finish on time due to lack of experience and time, but will most likely work on this
 * when revisiting this project. 
 * 
 * Original intent was to create a way to start the game over through a click of a button, and keeping track of your high score.
 * There would be a 3 second countdown before the game would properly begin, and at the end it would display your high scores before being asked
 * to start over. 
 */

public class GameStart : MonoBehaviour 
{

    private float countDown = 3f;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI countDownTimer;

    // 
    private void Start()
    {
        CountDown();   
    }

    private void Update()
    {
        countDown -= Time.deltaTime;
        CountDownDisplay(countDown);
    }
    void CountDown()
    {
        highScore.gameObject.SetActive(false);
        countDownTimer.gameObject.SetActive(true);

    }

    void CountDownDisplay(float timeToDisplay)
    {
        timeToDisplay += 1; // To ensure the timer shows 00:00 at the end, not -00:01

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (countDownTimer != null)
        {
            countDownTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
