using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Scripts.InventorySystem.Interfaces;
using Assets.Scripts.InventorySystem;
using Assets.Scripts.Player_Scripts;

namespace Assets.Scripts.InventorySystem.Items.Potions
{
    class HealthPotion : Item, IConsumable
    {
        public int amountToHeal;
        public void Eat(Player whoEats)
        {
            whoEats.GiveHealth(amountToHeal);
            print("Healed " + amountToHeal + " damage");
            whoEats.inventory.Items.Remove(this);
        }
    }
}
