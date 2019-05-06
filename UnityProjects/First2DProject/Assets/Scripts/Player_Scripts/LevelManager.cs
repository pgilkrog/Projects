using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int level;
    public int currentExp;
    public int maxExp;

    public AudioSource levelSound;

    // Use this for initialization
    void Start()
    {
        level = 1;
        currentExp = 0;
        maxExp = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetExperience(int amount)
    {
        if ((currentExp + amount) >= maxExp)
        {
            level += 1;
            currentExp = (currentExp + amount) % maxExp;
            maxExp += 50;

            gameObject.GetComponent<PlayerHealthManager>().playerMaxHealth += 20;
            gameObject.GetComponent<PlayerManaManager>().maxMana += 30;

            gameObject.GetComponent<PlayerHealthManager>().playerCurrentHealth = gameObject.GetComponent<PlayerHealthManager>().playerMaxHealth;
            gameObject.GetComponent<PlayerManaManager>().currentMana = gameObject.GetComponent<PlayerManaManager>().maxMana;
            levelSound.Play();
        }
        else
        {
            currentExp += amount;
        }
    }
}
