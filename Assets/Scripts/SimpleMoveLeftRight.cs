using UnityEngine;

public class SimpleMoveUpDown : MonoBehaviour
{
    public float speed = 2f; // Movement speed
    public float height = 1f; // Movement range

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, startY + Mathf.Sin(Time.time * speed) * height, transform.position.z);
    }
}
