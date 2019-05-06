using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.CharacterSystem.Interfaces
{
    interface IHealthManager
    {
        void TakeHealth(int amount);
        void GiveHealth(int amount);
        void MoreMaxHealth(int amount);
        int GetHealth();
        int GetMaxHealth();
    }
}
