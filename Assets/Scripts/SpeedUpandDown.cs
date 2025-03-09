using UnityEngine;

public class SpeedUpandDown : MonoBehaviour
{
    public float speed = 2f; // Speed of movement
    public float height = 1f; // Max height difference

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Store initial position
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
