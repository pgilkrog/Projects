using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Player_Scripts
{
    class OldSpellManager : MonoBehaviour
    {
        public GameObject spell;
        public Player player;
        void Awake()
        {
            player = FindObjectOfType<Player>();
        }
        public void ShootFireball()
        {
            if (player.CheckMana() >= 10)
            {
                GameObject clone = (GameObject)Instantiate(spell, gameObject.GetComponent<Rigidbody2D>().transform.position, Quaternion.identity);

                if (Input.GetKey(KeyCode.A))
                {
                    clone.GetComponent<Rigidbody2D>().AddForce((Vector3.left * 50000) * Time.deltaTime);
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    clone.GetComponent<Rigidbody2D>().AddForce((Vector3.right * 50000) * Time.deltaTime);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    clone.GetComponent<Rigidbody2D>().AddForce((Vector3.down * 50000) * Time.deltaTime);
                }
                else
                {
                    clone.GetComponent<Rigidbody2D>().AddForce((Vector3.up * 50000) * Time.deltaTime);
                }

                player.UseMana(10);
                Destroy(clone, 2.0f);
            }
        }
    }
}
