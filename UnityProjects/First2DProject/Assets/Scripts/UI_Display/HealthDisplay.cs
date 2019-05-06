using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.Player_Scripts;

public class HealthDisplay : MonoBehaviour
{
    public Text textHealth;
    public Slider slideHealth;
    public Player player;

    // Use this for initialization
    void Start()
    {

    }

    void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        textHealth.text = "HP: " + player.GetHealth().ToString() + " / " + player.GetMaxHealth().ToString();

        slideHealth.maxValue = player.GetMaxHealth();
        slideHealth.value = player.GetHealth();
        //textHealth.text = "HP: " + thePlayer.gameObject.GetComponent<PlayerHealthManager>().playerCurrentHealth.ToString() + " / " +
        //    thePlayer.gameObject.GetComponent<PlayerHealthManager>().playerMaxHealth.ToString();

        //slideHealth.maxValue = thePlayer.gameObject.GetComponent<PlayerHealthManager>().playerMaxHealth;
        //slideHealth.value = thePlayer.gameObject.GetComponent<PlayerHealthManager>().playerCurrentHealth;
    }
}
