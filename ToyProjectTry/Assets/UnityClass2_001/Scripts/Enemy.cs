using ClassStudy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class Enemy : MonoBehaviour
    {
        [Header("�Ӽ�")]
        public float speed = 5;
        private Vector3 dir;   // ���Ͱ� �̵��� ����

        public GameObject[] explosionEffect;
        

        private void Start()
        {
            // ������ ������ �����ϰ� �����ִ� ����
            GetDirectionPattern();
        }

        private void GetDirectionPattern()
        {
            int randValue = UnityEngine.Random.Range(0, 10); // 0 ~ 9 ������ ���� �������� �����´�.

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
                GameObject smoke = Instantiate(explosionEffect[1]);
                smoke.transform.position = transform.position;
            }

            if (other.CompareTag("Player"))
            {
                GameObject smoke = Instantiate(explosionEffect[0]);
                smoke.transform.position = transform.position;
            }


            Destroy(other.gameObject); // �� �װ�
            Destroy(gameObject);       // �� ����
        }
    }
}
