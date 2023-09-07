using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateYCounterClockwise : MonoBehaviour

{
    public float rotationSpeed = 60.0f; 
    
    void Update()
    {
        RotateCounterClockwiseY();
    }

    void RotateCounterClockwiseY()
    {
        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
    }
}
