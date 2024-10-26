using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

namespace ClassStudy
{
    public class Score : MonoBehaviour
    {
        [Header("¼Ó¼º")]
        public TextMeshProUGUI currentscore;
        public TextMeshProUGUI bestscore;

        public int score;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            currentscore.text = $"Score : {score}";
        }
    }
}
