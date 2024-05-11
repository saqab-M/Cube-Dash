using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpin : MonoBehaviour
{
    public float RotSpeed;

    private void Update()
    {
        transform.Rotate(RotSpeed * Time.deltaTime, 0, 0);
    }
}
