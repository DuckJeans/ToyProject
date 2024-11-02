using Sample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class ItemMove : MonoBehaviour
    {
        public float speed;
        int randomDir;

        private void Start()
        {
            randomDir = Random.Range(1, 3);
            randomDir = randomDir == 1 ? 1 : -1;
        }

        private void Update()
        {
            Vector3 dir = new Vector3(randomDir, -1, 0);
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                PlayerHP player = other.GetComponent<PlayerHP>();
                player.IncreaseHP();
                Destroy(gameObject);
            }
        }
    }
}
