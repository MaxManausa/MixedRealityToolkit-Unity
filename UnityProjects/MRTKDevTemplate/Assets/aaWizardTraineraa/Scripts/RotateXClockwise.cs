using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateXClockwise : MonoBehaviour

{
    public float rotationSpeed = 60.0f; 
    
    void Update()
    {
        RotateClockwiseX();
    }
    
    void RotateClockwiseX()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

}
