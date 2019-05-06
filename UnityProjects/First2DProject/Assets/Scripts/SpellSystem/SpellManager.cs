using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using Assets.Scripts.SpellSystem;
using Assets.Scripts.SpellSystem.Spells;
using Assets.Scripts.SpellSystem.Interfaces;


namespace Assets.Scripts.SpellSystem
{
    public class SpellManager : MonoBehaviour, ISpellManager
    {
        public List<Spell> spells;
        public List<GameObject> gameSpells;

        public GameObject activeSpell;

        public SpellManager()
        {
            spells = new List<Spell>();
            gameSpells = new List<GameObject>();
            AddSpell(null);
        }
        public void ldfjg()
        {
            ActiveSpell(spells.FirstOrDefault());
        }
        
        void Awake()
        {
            gameSpells.Add(GameObject.Find("Assets/Prefabs/Fireball"));
            activeSpell = gameSpells.FirstOrDefault();
        }

        public void ActiveSpell(Spell spell)
        {
            //GameObject newSpell = GameObject(spell.name);
            //activeSpell = newSpell;
            activeSpell = gameSpells.FirstOrDefault();
        }

        public void AddSpell(Spell spell)
        {
            spell = new Fireball();

            spells.Add(spell);
        }

        public void Cast()
        {
            GameObject spell = activeSpell;
            if (gameObject.GetComponent<PlayerManaManager>().currentMana >= 10)
            {
                GameObject clone = (GameObject)Instantiate(activeSpell, gameObject.GetComponent<Rigidbody2D>().transform.position, Quaternion.identity);

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

                gameObject.GetComponent<PlayerManaManager>().UseMana(10);
                Destroy(clone, 2.0f);
            }
        }

        public void CheckMana()
        {
            throw new NotImplementedException();
        }

        public GameObject ChooseSpell(Spell spell)
        {
            GameObject newSpell = GameObject.Find(spell.name);
            activeSpell = newSpell;
            foreach (Spell s in spells)
            {
                if (s.name.Equals(spell.name)){
                    //newSpell = s;
                }
            }
            return newSpell;
        }

        public void RemoveSpell(Spell spell)
        {
            spells.Remove(spell);
        }
    }
}
