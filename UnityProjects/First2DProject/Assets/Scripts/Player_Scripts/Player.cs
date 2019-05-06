using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using Assets.Scripts.CharacterSystem.Interfaces;
using Assets.Scripts.CharacterSystem;

using Assets.Scripts.InventorySystem.Interfaces;
using Assets.Scripts.InventorySystem;
using Assets.Scripts.SpellSystem;

namespace Assets.Scripts.Player_Scripts
{
    public class Player : Character, IDamagable
    {
        public Inventory inventory;
        public SpellManager spellmanager;

        public Player() : base(charName, health, maxHealth, mana, maxMana, strength, intellect, dexterity)
        {
            inventory = new Inventory();
            spellmanager = new SpellManager();

            health = 100;
            maxHealth = 100;
            mana = 100;
            maxMana = 100;

            strength = 1;
            intellect = 1;
            dexterity = 1;
        }

        public void TakeDamage(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
