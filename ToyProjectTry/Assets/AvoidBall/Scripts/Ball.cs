using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Ball : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            //Tag�� Player�϶��� �浹
            if (collision.collider.CompareTag("Player"))
            {
                
            }

            if (collision.collider.CompareTag("NoneDisabled"))
            {
                Destroy(gameObject);
            }
        }
    }
}
