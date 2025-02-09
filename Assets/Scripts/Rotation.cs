using UnityEngine;

namespace AG1916
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float rotationspeed = 50f;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(rotationspeed * Time.deltaTime, 0f, 0f);
        }
    } 
}
