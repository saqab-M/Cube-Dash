using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float RotSpeed;

    private void Update()
    {
        transform.Rotate(RotSpeed * Time.deltaTime, 0, 0);
    }
}
