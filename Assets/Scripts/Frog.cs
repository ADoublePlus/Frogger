using UnityEngine;
using UnityEngine.SceneManagement;

namespace Frogger
{
    public class Frog : MonoBehaviour
    {
        public Rigidbody2D rigid2D;

        // Update is called once per frame
        void Update ()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rigid2D.MovePosition(rigid2D.position + Vector2.right);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rigid2D.MovePosition(rigid2D.position + Vector2.left);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rigid2D.MovePosition(rigid2D.position + Vector2.up);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rigid2D.MovePosition(rigid2D.position + Vector2.down);
            }
        }

        void OnTriggerEnter2D (Collider2D _col2D)
        {
            if (_col2D.tag == "Car")
            {
                Debug.Log("WE LOST!");

                Score.currentScore = 0;

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}