using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Obstacle;
    public Transform SpawnPoint;
    public float SpawnRateMin;
    public float SpawnRateMax;

    IEnumerator SpawnObsatcles()
    {
        while (true) 
        {
            float waitTime = Random.Range(SpawnRateMin, SpawnRateMax);

            yield return new WaitForSeconds(waitTime);

            Instantiate(Obstacle, SpawnPoint.position, Quaternion.identity);
        }
    }

    private void Start()
    {
        StartCoroutine("SpawnObsatcles");
    }



}
