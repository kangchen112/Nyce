using UnityEngine;

namespace AG1916
{
    public class MoveUpAndDown : MonoBehaviour
    {
        public float speed = 2f; //Movement Speed
        public float height = 1f; //Maximum height for movement

        private Vector3 startPosition;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            startPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = startPosition + new Vector3(0f, Mathf.Sin(Time.time * speed) * height, 0f);
        }
    } 
}
