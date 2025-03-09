using UnityEngine;

public class Teleportpuppet : MonoBehaviour
{
    public int puppedId;
    public string puppedName;
    public Vector3 rotationAxis = Vector3.right;
    public float rotationSpeed = 30.0f;

    private void Update()
    {
        transform.RotateAround(transform.position, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}