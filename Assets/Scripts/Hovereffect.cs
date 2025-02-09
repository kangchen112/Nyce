using UnityEngine;

namespace AG1916
{
    public class HoverEffect : MonoBehaviour
    {
        
        public float amplitude = 0.5f; // How high it moves
        public float speed = 2f;      // How fast it moves

        private Vector3 startPosition;

        void Start()
        {
            startPosition = transform.position;
        }

        void Update()
        {
            transform.position = startPosition + new Vector3(0f, Mathf.Sin(Time.time * speed) * amplitude, 0f);
        }
    } 
}

