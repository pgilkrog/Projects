using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource zombieSound;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        zombieSound.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<StatsScript>().sleep <= 40 || 
            player.GetComponent<StatsScript>().thirst <= 40 ||
            player.GetComponent<StatsScript>().hunger <= 40)
        {
            zombieSound.volume = 1;
        }
        else
        {
            zombieSound.volume = 0;
        }
    }
}
