using UnityEngine;

public class ReturnToStartingPosition : MonoBehaviour
{
    [SerializeField] private Transform startingTransform; // Use a Transform instead of Vector3
    private bool isReturning = false;
    public float maxDistance = 5f;
    public float returnSpeed = 2f; // Adjust the speed of the return movement

    private void Start()
    {
        // Store the initial local position of the object relative to its parent
        if (transform.parent != null)
        {
            startingTransform.localPosition = transform.localPosition;
        }
    }

    private void Update()
    {
        // Calculate the distance from the starting local position
        float distance = Vector3.Distance(transform.localPosition, startingTransform.localPosition);

        // Check if the object has moved farther than the maxDistance
        if (distance > maxDistance)
        {
            // Start the return process
            isReturning = true;

            // Disable kinematic behavior
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = true;
            }
        }

        // If the object is returning, move it towards the starting local position
        if (isReturning)
        {
            float step = returnSpeed * Time.deltaTime;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, startingTransform.localPosition, step);

            // Check if the object is close enough to the starting local position
            float remainingDistance = Vector3.Distance(transform.localPosition, startingTransform.localPosition);
            if (remainingDistance <= 0.01f || (transform.parent != null && Vector3.Dot(transform.localPosition - startingTransform.localPosition, transform.parent.forward) < 0f))
            {
                // Re-enable kinematic behavior
                Rigidbody rb = GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.isKinematic = false;
                }

                // Reset the returning flag
                isReturning = false;
            }
        }
    }

    public void InstantReturn()
    {
        if (transform.parent != null)
        {
            transform.localPosition = startingTransform.localPosition;
        }
    }
}