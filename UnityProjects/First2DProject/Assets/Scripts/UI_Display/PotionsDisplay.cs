using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Player_Scripts;
using Assets.Scripts.InventorySystem.Items.Potions;
using Assets.Scripts.InventorySystem;

namespace Assets.Scripts.UI_Display
{
    class PotionsDisplay : MonoBehaviour
    {
        public GameObject player;
        public Text Health;
        public Text ManaPots;

        int amount;
        int manaAmount;

        void Update()
        {
            PlusAmount();
            Health.text = amount.ToString();
            ManaPots.text = manaAmount.ToString();
        }

        public void PlusAmount()
        {
            amount = 0;
            manaAmount = 0;
            foreach (Item m in player.gameObject.GetComponent<Player>().inventory.Items)
            {
                if (m is HealthPotion)
                {
                    amount++;
                }
                else if(m is ManaPotion)
                {
                    manaAmount++;
                }
                else
                {
                    //Do nothing 
                }
            }

        }
    }
}
