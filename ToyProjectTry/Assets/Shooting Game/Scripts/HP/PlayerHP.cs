using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class PlayerHP : HP_system // HP_system¿ª ªÛº”
    {
        public GameObject[] lifeCount;

        private void Awake()
        {
            lifeCount = new GameObject[maxHP];

            for (int i = 0; i < maxHP; i++)
            {
                string s = "image" + i;
                lifeCount[i] = GameObject.Find($"Canvas/HUD/{s}").gameObject;
            }
        }

        protected override void UpdateUI()
        {
            for (int i = 0; i < lifeCount.Length; i++)
            {
                if (i < hp && !lifeCount[i].activeSelf)
                {
                    lifeCount[i].SetActive(true);
                }

                else if (i >= hp && lifeCount[i].activeSelf)
                {
                    lifeCount[i].SetActive(false);
                }
            }
        }
    }
}
