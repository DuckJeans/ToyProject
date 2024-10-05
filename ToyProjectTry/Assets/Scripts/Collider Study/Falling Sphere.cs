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
            //Tag�� NoneDisabled�̸� �浹���� ����, �� �ڵ带 �ۼ����� ������
            if(collision.collider.CompareTag("NoneDisabled"))
            {
                return;
            }



            Debug.Log(collision.gameObject.name);   //�浹�� ������Ʈ�� �̸� ���
            collision.gameObject.SetActive(false);  //�浹�� ������Ʈ�� ��Ȱ��ȭ
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
