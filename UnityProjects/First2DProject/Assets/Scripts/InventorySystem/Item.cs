using Assets.Scripts.InventorySystem.Interfaces;
using Assets.Scripts.Player_Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.InventorySystem
{
    public abstract class Item : MonoBehaviour, IPickup
    {
        public string Name;

        public void Drop(IInventory inventory)
        {
            inventory.RemoveItem(this);
        }

        public void PickUp(IInventory inventory)
        {
            inventory.AddItem(this);
            this.gameObject.SetActive(false);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            var currentPlayer = other.gameObject.GetComponent<Player>();
            if (currentPlayer != null)
            {
                PickUp(currentPlayer.inventory);
                print("Picked up item " + Name);
            }
        }
    }
}