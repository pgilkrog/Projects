using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Assets.Scripts.InventorySystem.Interfaces;
using Assets.Scripts.InventorySystem;
using Assets.Scripts.Player_Scripts;

namespace Assets.Scripts.InventorySystem.Items.Potions
{
    public class ManaPotion : Item, IConsumable
    {
        public int healAmount = 50;

        public void Eat(Player whoEatsIt)
        {
            whoEatsIt.GiveMana(healAmount);
            print("Healed " + healAmount + " damage");
            whoEatsIt.inventory.Items.Remove(this);
        }
    }
}
