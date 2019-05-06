using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Player_Scripts;

namespace Assets.Scripts.InventorySystem.Interfaces
{
    public interface IConsumable
    {
        void Eat(Player whoEats);
    }
}
