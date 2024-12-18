﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(10);
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Player")
        {
            //Do nothing
        }
        else
        {
            //Destroy the fireball
            Destroy(gameObject);
        }
    }
}
