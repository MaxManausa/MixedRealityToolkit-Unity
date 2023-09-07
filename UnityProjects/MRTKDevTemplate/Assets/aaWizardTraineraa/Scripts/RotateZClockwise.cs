using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZClockwise : MonoBehaviour
{
    public float rotationSpeed = 60.0f;

    void Update()
    {
        RotateClockwiseZ();
    }

    void RotateClockwiseZ()
    {
        transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
    }
}