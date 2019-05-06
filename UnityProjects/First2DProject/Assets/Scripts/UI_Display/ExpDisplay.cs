using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpDisplay : MonoBehaviour
{
    public Text levelText;
    public Text textExp;
    public Slider slideExp;
    public GameObject thePlayer;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textExp.text = "Experience: " + thePlayer.gameObject.GetComponent<LevelManager>().currentExp.ToString() + " / " +
            thePlayer.gameObject.GetComponent<LevelManager>().maxExp.ToString();

        levelText.text = thePlayer.gameObject.GetComponent<LevelManager>().level.ToString();

        slideExp.maxValue = thePlayer.gameObject.GetComponent<LevelManager>().maxExp;
        slideExp.value = thePlayer.gameObject.GetComponent<LevelManager>().currentExp;
    }
}
