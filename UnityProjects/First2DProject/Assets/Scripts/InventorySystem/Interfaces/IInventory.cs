using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.InventorySystem.Interfaces
{
    public interface IInventory
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
        void EquipItem(Item item);
        void UseItem(Item item);
    }
}
