using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] Obstacles;
    //public GameObject Obstacle2;


    public Transform SpawnPoint;
    public float SpawnRateMin;
    public float SpawnRateMax;

    public GameObject ScoreObj;
    public GameObject StartBtn;
    public GameObject player;
    public GameObject playerIcon;

    public ScoreKeep scoreScript;

    IEnumerator SpawnObsatcles()
    {
        while (true) 
        {

            GameObject obstacleToSpawn = Obstacles[Random.Range(0, Obstacles.Length)];


            float waitTime = Random.Range(SpawnRateMin, SpawnRateMax);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacleToSpawn, SpawnPoint.position, Quaternion.identity);
        }
    }

    public void GameStart()
    { 

        StartBtn.SetActive(false);
      //  ScoreObj.SetActive(true);
        player.SetActive(true);
        playerIcon.SetActive(false);

        scoreScript.StartNewRound();

        StartCoroutine("SpawnObsatcles");
    }



}
