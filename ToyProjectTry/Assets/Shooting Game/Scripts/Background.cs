using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class Background : MonoBehaviour
    {
        [Header("¼Ó¼º")]
        public Material BGMat;
        public float scrollSpeed = 0.2f;
        public Vector2 dirVec = Vector2.zero;
        // Update is called once per frame
        void Update()
        {
            Vector2 dirction = dirVec;
            BGMat.mainTextureOffset += dirction * scrollSpeed * Time.deltaTime;
        }
    }
}
