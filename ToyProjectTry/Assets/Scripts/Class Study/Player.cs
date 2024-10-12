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

        // 게임이 시작된 후 한 번만 실행한다.
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Hello Player!");

            // 플레이어의 위치 z : 40으로 이동한다.
            //위치를 이동
            transform.position = new Vector3(5, 5, 20);

            //회전

            transform.Rotate(new Vector3(0, 0, 0));

            //크기 변경

            transform.localScale = new Vector3(1, 1, 1);
        }

        // 반복되는 로직을 처리 할 수 있습니다.
        // Frame : 1초에 60Frame FPS : Frame Per Second
        // 1Frame을 생성할 때 update가 한번 실행된다.
        // Update is called once per frame
        void Update()
        {
            // 플레이어의 입력을 구현.
            //키보드

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

            //마우스


            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Mouse Down");
            }

            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("Mouse Up");
            }

            //중력
            //transform.Translate(new Vector3(0, -9.8f, 0) * Time.deltaTime);

        }
    }
}
