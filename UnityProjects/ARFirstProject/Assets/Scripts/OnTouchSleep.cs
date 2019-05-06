using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchSleep : MonoBehaviour
{
    public GameObject player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<StatsScript>().sleep =
                player.GetComponent<StatsScript>().maxSleep;
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
            if (hit.collider.CompareTag("Sleep"))
            {
                // Do something (open an URL in your case).
                player.GetComponent<StatsScript>().sleep =
                    player.GetComponent<StatsScript>().maxSleep;
            }
        }


    }
}
