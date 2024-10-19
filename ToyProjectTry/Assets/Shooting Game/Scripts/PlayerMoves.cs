using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooting
{
    public class PlayerMoves : MonoBehaviour
    {

        [Header("¼Ó¼º")]
        public float speed = 5f;

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir = new Vector3(horizontal, vertical, 0);
            dir.Normalize();

            transform.position = transform.position + dir * speed * Time.deltaTime;
        }
    }
}
