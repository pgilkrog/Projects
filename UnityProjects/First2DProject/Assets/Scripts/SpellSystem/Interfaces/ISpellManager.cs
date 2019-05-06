using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.SpellSystem.Interfaces
{
    interface ISpellManager
    {
        void Cast();
        void ActiveSpell(Spell spell);
        void CheckMana();
        GameObject ChooseSpell(Spell spell);
        void AddSpell(Spell spell);
        void RemoveSpell(Spell spell);
    }
}
