using Assets.Scripts.InventorySystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.InventorySystem
{
    public class Inventory : IInventory
    {
        public int maxInvSpace = 100;
        public List<Item> Items;

        public Inventory()
        {
            Items = new List<Item>(maxInvSpace);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void EquipItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void UseItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
