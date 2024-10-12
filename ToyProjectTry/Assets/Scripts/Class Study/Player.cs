using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Player : MonoBehaviour

    {
        public float jumpPower = 100f;
        public bool isGrounded;
        public LayerMask ground;

        // ������ ���۵� �� �� ���� �����Ѵ�.
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hello Player!");

            // �÷��̾��� ��ġ z : 40���� �̵��Ѵ�.
            //��ġ�� �̵�
            transform.position = new Vector3(5, 5, 20);

            //ȸ��

            transform.Rotate(new Vector3(0, 0, 0));

            //ũ�� ����

            transform.localScale = new Vector3(1, 1, 1);
        }

        // �ݺ��Ǵ� ������ ó�� �� �� �ֽ��ϴ�.
        // Frame : 1�ʿ� 60Frame FPS : Frame Per Second
        // 1Frame�� ������ �� update�� �ѹ� ����ȴ�.
        // Update is called once per frame
        void Update()
        {
            // �÷��̾��� �Է��� ����.
            //Ű����

            ////////////////////////////////////////////

            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("KeyDown D");
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(0, 0, -3) * Time.deltaTime);
            }

            //////////////////////////////////////////

            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Jump");

                transform.Translate(new Vector3(0, jumpPower, 0) * Time.deltaTime);
            }

            ///////////////////////////////////////////////

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("KeyDown A");
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(0, 0, 3) * Time.deltaTime);
            }

            /////////////////////////////////////////

            //���콺


            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mouse Down");
            }

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Mouse Up");
            }

            //�߷�
            //transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);

        }
    }
}
