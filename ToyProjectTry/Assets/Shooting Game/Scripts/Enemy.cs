using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Enemy : MonoBehaviour
    {
        [Header("¼Ó¼º")]
        public float speed = 2;
        private Vector3 dir;

        private void Start()
        {
            int ranVaule = UnityEngine.Random.Range(0, 10);

            if (ranVaule < 3)
            {
                GameObject player = GameObject.Find("Player");

                dir = player.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }


        // Update is called once per frame
        void Update()
        {
            transform.position +=  dir * speed * Time.deltaTime;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeadZone")) return;

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
