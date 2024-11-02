using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace ClassStudy
{
    public class HP_system : MonoBehaviour
    {
        [SerializeField] protected int hp; //����ü��
        public int maxHP; //�ִ�ü��
        public int HP
        {
            get { return hp; }
            set 
            { 
                hp = value; //hp���� value������ ����

                if(hp >= maxHP) hp = maxHP; //�ִ�ü���� �������ϰ� ��

                UpdateUI();
            }
        }

        protected virtual void UpdateUI()
        {
            
        }
        private void Awake()
        {

        }

        public void DecreaseHP(int damage = 1)
        {
            HP -= damage;

        }
        public void IncreaseHP(int damage = 1)
        {
            HP += damage;

        }

        public bool isDead()
        {
            return HP <= 0 ? true : false;
        }

        private void Start()
        {
            HP = 3; //SetHP(3);
            Debug.Log(HP); //Debug.Log(GetHP());
            hp = maxHP;
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.G))
            {
                DecreaseHP();
            }
            if(Input.GetKeyDown(KeyCode.H))
            {
                IncreaseHP();
            }
        }
    }
}
