using UnityEngine;
using UnityEngine.UI;

namespace Frogger
{
    public class Score : MonoBehaviour
    {
        public Text scoreText;

        public static int currentScore = 0;

        // Use this for initialization
        void Start ()
        {
            scoreText.text = currentScore.ToString();
        }
    }
}