using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject player;

    Vector3 doorPosition;
    Vector3 playerPosition;

    int range = 1;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        doorPosition = gameObject.transform.position;
        playerPosition = player.transform.position;
        bool open = false;

        if (open == false && Vector3.Distance(playerPosition, doorPosition) < range)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                open = true;
                gameObject.SetActive(false);
            }
        }
        else if (open == true && Vector3.Distance(playerPosition, doorPosition) < range)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                open = false;
                gameObject.SetActive(true);
            }
        }
    }

    public void OpenCloseDoor()
    {

    }
}
