using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using Assets.Scripts.CharacterSystem.Interfaces;

namespace Assets.Scripts.CharacterSystem
{
    public abstract class Character : MonoBehaviour, IManaManager, IHealthManager
    {
        public static string charName;

        public static int health;
        public static int maxHealth { get; set; }
        public static int mana { get; set; }
        public static int maxMana { get; set; }

        public static int strength;
        public static int intellect;
        public static int dexterity;

        public static bool isAlive = true;

        public Character(string charName, int health, int maxHealth, int mana, int maxMana, 
            int strength, int intellect, int dexterity)
        {

        }

        public int CheckMana()
        {
            return mana;
        }

        public void GenerateMana(int amount)
        {
            throw new NotImplementedException();
        }

        public void GiveMana(int amount)
        {
            mana += amount;
        }

        public void LessMaxMana(int amount)
        {
            throw new NotImplementedException();
        }

        public void MoreMaxMana(int amount)
        {
            throw new NotImplementedException();
        }

        public void UseMana(int amount)
        {
            mana -= amount;
        }

        public int CheckMaxMana()
        {
            return maxMana;
        }

        public void TakeHealth(int amount)
        {
            health -= amount;
        }

        public void GiveHealth(int amount)
        {
            health += amount;
        }

        public void MoreMaxHealth(int amount)
        {
            throw new NotImplementedException();
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetMaxHealth()
        {
            return maxHealth;
        }
    }
}
