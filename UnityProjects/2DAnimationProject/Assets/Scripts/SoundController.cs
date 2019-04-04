using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource gunShot;
    public AudioSource foodStep;

    public AudioSource massMurder;
    public AudioSource tripleMurder;
    public AudioSource stabIt;
    public AudioSource payTheCons;
    public AudioSource killReviveKill;

    public bool grounded;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WalkSound();
    }

    public void WalkSound()
    {
        if (!foodStep.isPlaying && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && grounded)
        {
            foodStep.Play();
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            foodStep.Stop();
        }
        else if (!grounded)
        {
            foodStep.Stop();
        }
    }

    public void PlayRandomSaying()
    {
        var numb = Random.Range(1, 6);

        if(!massMurder.isPlaying && !tripleMurder.isPlaying && !stabIt.isPlaying
            && !payTheCons.isPlaying && !killReviveKill.isPlaying)
        switch (numb)
        {
            case 1:
                massMurder.Play();
                break;
            case 2:
                tripleMurder.Play();
                break;
            case 3:
                stabIt.Play();
                break;
            case 4:
                payTheCons.Play();
                break;
            case 5:
                killReviveKill.Play();
                break;
        }
    }
}
