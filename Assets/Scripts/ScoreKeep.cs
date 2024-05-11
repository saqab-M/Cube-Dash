using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{

    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI highScoreTxt;

    int score = 0;
    int highScore = 0;

    private const string HIGH_SCORE_KEY = "HighScore";
    private const string LAST_SCORE_KEY = "lastScore";

    private void Start()
    {
        score = PlayerPrefs.GetInt(LAST_SCORE_KEY, 0);
        highScore = PlayerPrefs.GetInt(HIGH_SCORE_KEY,0);
        UpdateScore();
        UpdateHighScore();

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObstacleWireFrame") 
        {
            IncreaseScore();
        }
    }

    public void IncreaseScore(int points = 1)
    {
        score = score + points;
        UpdateScore();

        //save high score if its higher that the current stored
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, highScore);
            PlayerPrefs.Save(); // save changes to player prefs
        }
    }
    private void UpdateScore() 
    {
        scoreTxt.text = score.ToString();
    }

    private void UpdateHighScore() 
    { 
        highScoreTxt.text = "High Score: " + highScore.ToString();
    }

    public void StartNewRound()
    {
        score = 0;
        UpdateScore();
    }
    public void SaveScore() 
    {
        PlayerPrefs.SetInt(LAST_SCORE_KEY, score);
        if (score > highScore)
        {
            PlayerPrefs.SetInt(HIGH_SCORE_KEY, score);
        }
        PlayerPrefs.Save();
    }
}
