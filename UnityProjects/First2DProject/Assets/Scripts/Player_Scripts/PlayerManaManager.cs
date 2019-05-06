using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManaManager : MonoBehaviour {

    public int maxMana;
    public int currentMana;

    public float waitTime;
    private float waitCounter;

    // Use this for initialization
    void Start () {
        currentMana = maxMana;
        waitCounter = waitTime;
    }
	
	// Update is called once per frame
	void Update () {
        waitCounter -= Time.deltaTime;

        if (currentMana < maxMana && waitCounter < 0) { 
            currentMana++;
            waitCounter = waitTime;
        }
	}

    public void GiveMana(int amount)
    {
        if (currentMana + amount > maxMana)
            currentMana = maxMana;
        else
            currentMana += amount;
    }

    public void UseMana(int amount)
    {
        if((currentMana -= amount) < 0)
            currentMana -= amount;
    }

    public void CastSpell(int manaUse)
    {

    }
}
