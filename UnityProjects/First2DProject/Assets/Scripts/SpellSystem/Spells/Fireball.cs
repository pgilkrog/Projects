using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using Assets.Scripts.SpellSystem;
using Assets.Scripts.SpellSystem.Interfaces;

namespace Assets.Scripts.SpellSystem.Spells
{
    class Fireball : Spell, IDoDamage
    {
        public Fireball() : base(spellName, description, manaCost, timeToCast, cooldown)
        {
            spellName = "Fireball";
            description = "Shoots a powerfull ball of deadly fire";
            manaCost = 10;
            timeToCast = 1;
            cooldown = 1;
        }
        public void DoDamage(int amount)
        {
            throw new NotImplementedException();
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                //Destroy(collision.gameObject);
                collision.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(10);
                Destroy(gameObject);
            }
            else if (collision.gameObject.tag == "Player")
            {
                //Do nothing
            }
            else
            {
                //Destroy the fireball
                Destroy(gameObject);
            }

            //if (gameObject.GetComponent<PlayerManaManager>().currentMana >= 10)
            //{
            //    GameObject clone = (GameObject)Instantiate(fireBall, gameObject.GetComponent<Rigidbody2D>().transform.position, Quaternion.identity);

            //    if (Input.GetKey(KeyCode.A))
            //    {
            //        clone.GetComponent<Rigidbody2D>().AddForce((Vector3.left * 50000) * Time.deltaTime);
            //    }
            //    else if (Input.GetKey(KeyCode.D))
            //    {
            //        clone.GetComponent<Rigidbody2D>().AddForce((Vector3.right * 50000) * Time.deltaTime);
            //    }
            //    else if (Input.GetKey(KeyCode.S))
            //    {
            //        clone.GetComponent<Rigidbody2D>().AddForce((Vector3.down * 50000) * Time.deltaTime);
            //    }
            //    else
            //    {
            //        clone.GetComponent<Rigidbody2D>().AddForce((Vector3.up * 50000) * Time.deltaTime);
            //    }

            //    gameObject.GetComponent<PlayerManaManager>().UseMana(10);
            //    Destroy(clone, 2.0f);
            //}
        }
    }
}
