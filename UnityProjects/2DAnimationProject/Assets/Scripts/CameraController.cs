using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
	public GameObject player;
	private Vector3 offset;

	void start(){
		offset = this.transform.position - player.transform.position;
	}

	void LateUpdate(){
		transform.position = new Vector3 (player.transform.position.x + offset.x, 4.2f, -10f);
		//this.transform.position = player.transform.position + offset;
	}
}
