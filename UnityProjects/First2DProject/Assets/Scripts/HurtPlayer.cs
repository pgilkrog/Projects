using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Player_Scripts;

public class HurtPlayer : MonoBehaviour {

    public int damageToGive;
    private Player player;

	// Use this for initialization
	void Start () {
		
	}

    void Awake()
    {
        player = FindObjectOfType<Player>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.TakeHealth(damageToGive);
            collision.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }
    }
}
