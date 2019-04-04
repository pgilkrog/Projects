using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Use this for initialization
    void Start()
    {
        var controls = gameObject.AddComponent<PlayerControls>();
        controls.bullet = bulletPrefab;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
