using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class FallingSphere : MonoBehaviour
    {

        public float point = 0;
        private void OnCollisionEnter(Collision collision)
        {
            //Tag가 NoneDisabled이면 충돌하지 말라, 이 코드를 작성하지 마세요
            if(collision.collider.CompareTag("NoneDisabled"))
            {
                return;
            }



            Debug.Log(collision.gameObject.name);   //충돌한 오브젝트의 이름 출력
            collision.gameObject.SetActive(false);  //충돌한 오브젝트를 비활성화
            point = point + 1;
            Debug.Log($"Point : {point}");
        }

        private void OnCollisionExit(Collision collision)
        {
            
        }

        private void OnCollisionStay(Collision collision)
        {
            
        }
    }
}
