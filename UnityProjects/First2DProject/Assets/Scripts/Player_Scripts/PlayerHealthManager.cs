using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

	// Use this for initialization
	void Start () {
        playerCurrentHealth = playerMaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (playerCurrentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    public void HurtPlayer(int amount)
    {
        playerCurrentHealth -= amount;
    }

    public void GiveHealth(int amount)
    {
        if (playerCurrentHealth + amount > playerMaxHealth)
            playerCurrentHealth = playerMaxHealth;
        else
            playerCurrentHealth += amount;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
