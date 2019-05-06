using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsScript : MonoBehaviour
{
    public float hunger;
    public float maxHunger = 100f;
    public float thirst;
    public float maxThirst = 100f;
    public float sleep;
    public float maxSleep = 100f;

    public float waitTimer;
    private float waitCounter;

    // Use this for initialization
    void Start()
    {
        hunger = maxHunger;
        thirst = maxThirst;
        sleep = maxSleep;
        waitCounter = waitTimer;
    }

    // Update is called once per frame
    void Update()
    {
        waitCounter -= Time.deltaTime;
        if(waitCounter <= 0)
        {
            hunger -= 3;
            thirst -= 4;
            sleep -= 1;
            waitCounter = waitTimer;
        }
        if (hunger <= 0 || thirst <= 0 || sleep <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}