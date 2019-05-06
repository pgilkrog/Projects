using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.CharacterSystem.Interfaces
{
    interface IManaManager
    {
        void GiveMana(int amount);
        void UseMana(int amount);
        void GenerateMana(int amount);
        void MoreMaxMana(int amount);
        void LessMaxMana(int amount);
        int CheckMana();
        int CheckMaxMana();
    }
}
