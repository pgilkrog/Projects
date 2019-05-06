using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatsScript : MonoBehaviour
{
    public Slider hungerSlide;
    public Slider thirstSlide;
    public Slider sleepSlide;

    public GameObject player;
    // Use this for initialization
    void Start()
    {
        hungerSlide.maxValue = player.GetComponent<StatsScript>().maxHunger;
        thirstSlide.maxValue = player.GetComponent<StatsScript>().maxThirst;
        sleepSlide.maxValue = player.GetComponent<StatsScript>().maxSleep;
    }

    // Update is called once per frame
    void Update()
    {
        hungerSlide.value = player.GetComponent<StatsScript>().hunger;
        thirstSlide.value = player.GetComponent<StatsScript>().thirst;
        sleepSlide.value = player.GetComponent<StatsScript>().sleep;
    }
}
