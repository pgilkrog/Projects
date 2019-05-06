using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Assets.Scripts.Player_Scripts;

public class ManaDisplay : MonoBehaviour
{
    public Text textMana;
    public Slider slideMana;
    //public GameObject thePlayer;
    private Player player;

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
        textMana.text = "Mana: " + player.CheckMana().ToString() + " / " + player.CheckMaxMana(); ;

        slideMana.maxValue = player.CheckMaxMana();
        slideMana.value = player.CheckMana();

        //slideMana.maxValue = thePlayer.gameObject.GetComponent<PlayerManaManager>().maxMana;
        //slideMana.value = thePlayer.gameObject.GetComponent<PlayerManaManager>().currentMana;
    }
}
