using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class BallSpawner : MonoBehaviour
    {

        public GameObject BallPrefab; //공장에서 찍어내는 물건
        public Transform[] spawnPosition;

        public float spawntime = 0.5f;
        public float timechecker = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Spawner();
        }

        private void Spawner()
        {
            int RandomIndex = Random.Range(0,3);

            Instantiate(BallPrefab, spawnPosition[RandomIndex]);
        }

        // Update is called once per frame
        void Update()
        {
            timechecker += Time.deltaTime;
            if (timechecker >= spawntime)
            {
                timechecker = 0f;
                Spawner();
            }
        }
    }
}
