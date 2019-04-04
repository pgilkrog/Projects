﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
}
