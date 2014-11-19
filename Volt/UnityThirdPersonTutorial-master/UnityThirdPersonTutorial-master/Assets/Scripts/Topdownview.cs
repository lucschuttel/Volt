using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Topdownview : MonoBehaviour {
	GameObject player;
	Vector3 positionoffset = Vector3.zero;
	Vector3 farpositionoffset = Vector3.zero;
	int camcount;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		camcount = 0;
		positionoffset = transform.position + player.transform.position;
		farpositionoffset = transform.position + player.transform.position+ new Vector3(0,20,0);

	}

	void Update () {

		transform.position = player.transform.position + positionoffset;
		if (Input.GetKeyDown (KeyCode.C)) {
			camcount++;}
		if (camcount ==1){
			transform.position = player.transform.position + farpositionoffset;
			}
		if (camcount ==2){
			transform.position = player.transform.position + positionoffset;
			}
		if (camcount == 2) {
			camcount = 0;		
		}	
	}
}
