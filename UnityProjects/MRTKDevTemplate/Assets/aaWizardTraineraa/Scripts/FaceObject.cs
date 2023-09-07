using UnityEngine;

public class FaceObject : MonoBehaviour
{
    private Transform mainCamera;

    private void Start()
    {
        // Find the main camera by its tag (you can also assign it in the inspector)
        mainCamera = Camera.main.transform;
    }

    private void Update()
    {
        if (mainCamera != null)
        {
            // Calculate the direction from this object's position to the main camera's position in global space
            Vector3 globalDirection = mainCamera.position - transform.position;

            // Create a rotation that looks in the global direction and set it as the local rotation
            transform.rotation = Quaternion.LookRotation(globalDirection.normalized, Vector3.up);
        }
    }
}