using ClassStudy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    [RequireComponent(typeof(EnemyHP))]

    public class Enemy : MonoBehaviour
    {
        [Header("속성")]
        public float speed = 5;
        private Vector3 dir;   // 몬스터가 이동할 방향

        public GameObject[] explosionEffect;

        [Header("Enemy HP system")]
        public EnemyHP hpController;

        private void Awake()
        {
            hpController = GetComponent<EnemyHP>();
        }


        private void Start()
        {
            // 몬스터의 방향을 랜덤하게 정해주는 로직
            GetDirectionPattern();
        }

        private void GetDirectionPattern()
        {
            int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 사이의 값을 랜덤으로 가져온다.

            if (randValue < 3)
            {
                GameObject target = GameObject.Find("Player");
                dir = target.transform.position - transform.position;
                dir.Normalize();
            }
            else
            {
                dir = Vector3.down;
            }
        }

        private void Update()
        {
            transform.position += dir * speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeadZone")) return;

            if (other.CompareTag("Bullet"))
            {
                GameObject fire = Instantiate(explosionEffect[1]);
                fire.transform.position = transform.position;

                hpController.DecreaseHP();

                Destroy(other.gameObject);

                if (hpController.isDead())
                {
                    Destroy(gameObject);
                }
            }

            if (other.CompareTag("Player"))
            {
                PlayerHP player = other.GetComponent<PlayerHP>();
                player.isDead();

                GameObject smoke = Instantiate(explosionEffect[0]);
                smoke.transform.position = transform.position;

                if (player.gameObject)
                {
                    Destroy(player);
                }
            }
        }
    }
}
