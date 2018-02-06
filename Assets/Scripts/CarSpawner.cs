using UnityEngine;

namespace Frogger
{
    public class CarSpawner : MonoBehaviour
    {
        public GameObject carPrefab;
        public Transform[] spawnPoints;

        public float spawnDelay = .3f;

        float nextTimeToSpawn = 0f;

        // Update is called once per frame
        void Update ()
        {
            if (nextTimeToSpawn <= Time.time)
            {
                SpawnCar();

                nextTimeToSpawn = Time.time + spawnDelay;
            }
        }

        void SpawnCar ()
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);

            Transform spawnPoint = spawnPoints[randomIndex];

            Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}