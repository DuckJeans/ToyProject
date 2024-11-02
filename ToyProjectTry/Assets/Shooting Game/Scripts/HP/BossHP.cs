using Sample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ClassStudy
{
    public class BossHP : EnemyHP
    {
        public Slider slider;
        public GameObject obj;

        protected override void Awake()
        {
            slider.maxValue = MaxHP;
            slider.minValue = 0;
            slider.value = 50;
        }
        protected override void UpdateUI()
        {
            base.UpdateUI();
            slider.value = hp;
        }

        
    }
}
