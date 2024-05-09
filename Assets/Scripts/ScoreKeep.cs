using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{

    public TextMeshProUGUI scoreTxt;

    int score = 0;

    private void Start()
    {
        UpdateScore();
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
    }
    private void UpdateScore() 
    {
        scoreTxt.text = score.ToString();
    }
}
