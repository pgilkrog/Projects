using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTouchFood : MonoBehaviour
{
    public GameObject player;
    public float amount = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if ((player.GetComponent<StatsScript>().hunger + amount) >= player.GetComponent<StatsScript>().maxHunger)
            {
                player.GetComponent<StatsScript>().hunger =
                    player.GetComponent<StatsScript>().maxHunger;
            }
            else
            {
                player.GetComponent<StatsScript>().hunger = player.GetComponent<StatsScript>().hunger + amount;
            }
        }
        RegisterModelTouch();
    }

    public void RegisterModelTouch()
    {
        // We assume that there was only one touch and take the first 
        // element in the array.
        Touch touch = Input.touches[0];
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(touch.position);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Food") && player.GetComponent<StatsScript>().hunger < 40)
            {
                // Do something (open an URL in your case).
                player.GetComponent<StatsScript>().hunger =
                    player.GetComponent<StatsScript>().maxHunger;
            }
        }
    }
}