using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class EnemyManger : MonoBehaviour
    {
        [Header("¼Ó¼º")]
        public GameObject EnemyFactory;
        public float createTime=1;
        public float currentTime;

        [Header("·£´ý")]
        public float minTime = 1f;
        public float maxTime = 3f;

        // Start is called before the first frame update
        void Start()
        {
            createTime = UnityEngine.Random.Range(minTime, maxTime);
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            if(createTime <= currentTime)
            {
                InstantEnemy();
                currentTime = 0;
                createTime = UnityEngine.Random.Range(minTime, maxTime);
            }
        }

        void InstantEnemy()
        {
            GameObject enemy = Instantiate(EnemyFactory);
            enemy.transform.position = transform.position;
        }
    }
}
