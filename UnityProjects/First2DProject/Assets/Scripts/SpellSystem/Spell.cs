using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using Assets.Scripts.SpellSystem.Interfaces;

namespace Assets.Scripts.SpellSystem
{
    public class Spell : MonoBehaviour
    {
        public static GameObject theSpell;

        public static string spellName;
        public static string description;

        public static int manaCost;
        public static int timeToCast;
        public static int cooldown;

        public Spell(string spellName, string description, int manaCost, int timeToCast, int cooldown)
        {

        }
    }
}
