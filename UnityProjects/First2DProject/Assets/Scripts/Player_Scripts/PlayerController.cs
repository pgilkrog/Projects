using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using Assets.Scripts.Player_Scripts;
using Assets.Scripts.InventorySystem;
using Assets.Scripts.InventorySystem.Items.Potions;
using Assets.Scripts.InventorySystem.Interfaces;
using Assets.Scripts.SpellSystem;

namespace Assets.Scripts.Player_Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 200;
        public float runSpeed = 0;

        private Rigidbody2D rb2d;
        public AudioSource walkSound;

        private Player player;
        void Awake()
        {
            player = FindObjectOfType<Player>();
        }
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();

        }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.velocity = new Vector2((moveHorizontal * (speed + runSpeed)) * Time.deltaTime, 
                (moveVertical * (speed + runSpeed)) * Time.deltaTime);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                runSpeed = 200;
                walkSound.pitch = 1f;
            }
            else
            {
                runSpeed = 0;
                walkSound.pitch = 0.5f;
            }
        }

        private void Update()
        {
            if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
            {
                if (!walkSound.isPlaying)
                {
                    walkSound.Play();
                }
            }
            else
            {
                walkSound.Stop();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<OldSpellManager>().ShootFireball();
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                if (player.inventory.Items.Any(x => x is HealthPotion))
                {
                    var food = player.inventory.Items.First(x => x is HealthPotion) as HealthPotion;
                    food.Eat(player);
                }
                else
                {
                    print("No more consumables");
                }
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                if (player.inventory.Items.Any(x => x is ManaPotion))
                {
                    var food = player.inventory.Items.First(x => x is ManaPotion) as ManaPotion;
                    food.Eat(player);
                }
                else
                {
                    print("You are out of fruit");
                }
            }
        }
    }
}