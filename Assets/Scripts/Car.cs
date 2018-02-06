using UnityEngine;

namespace Frogger
{
    public class Car : MonoBehaviour
    {
        public Rigidbody2D rigid2D;

        public float minSpeed = 8f;
        public float maxSpeed = 12f;

        float speed = 1f;

        // Use this for initialization
        void Start ()
        {
            speed = Random.Range(minSpeed, maxSpeed);
        }

        // Run every physics iteration
        void FixedUpdate ()
        {
            Vector2 forward = new Vector2(transform.right.x, transform.right.y);

            rigid2D.MovePosition(rigid2D.position + forward * Time.fixedDeltaTime * speed);
        }
    }
}