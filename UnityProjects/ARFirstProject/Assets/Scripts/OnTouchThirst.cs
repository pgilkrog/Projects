using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchThirst : MonoBehaviour
{
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && player.GetComponent<StatsScript>().thirst < 40)
        {
            player.GetComponent<StatsScript>().thirst =
                player.GetComponent<StatsScript>().maxThirst;
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
            if (hit.collider.CompareTag("Thirst") && player.GetComponent<StatsScript>().thirst < 40)
            {
                // Do something (open an URL in your case).
                player.GetComponent<StatsScript>().thirst =
                    player.GetComponent<StatsScript>().maxThirst;
            }
        }
    }
}
