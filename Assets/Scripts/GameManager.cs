using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Obstacle;
    public Transform SpawnPoint;
    public float SpawnRateMin;
    public float SpawnRateMax;

    public GameObject ScoreObj;
    public GameObject StartBtn;
    public GameObject player;

    IEnumerator SpawnObsatcles()
    {
        while (true) 
        {
            float waitTime = Random.Range(SpawnRateMin, SpawnRateMax);

            yield return new WaitForSeconds(waitTime);

            Instantiate(Obstacle, SpawnPoint.position, Quaternion.identity);
        }
    }

    public void GameStart()
    { 

        StartBtn.SetActive(false);
        ScoreObj.SetActive(true);
        player.SetActive(true);


        StartCoroutine("SpawnObsatcles");
    }



}
