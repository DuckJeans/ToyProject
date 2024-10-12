using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ClassStudy
{
    public class MenuController : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void GameStart()
        {
            SceneManager.LoadScene(1);      //0¹ø¾À ÀÎÆ®·Î ¾À - 1¹ø¾À ¸ÞÀÎ °ÔÀÓ ¾À
        }
    }
}
