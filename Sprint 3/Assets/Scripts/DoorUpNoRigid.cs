﻿using UnityEngine;
using System.Collections;

public class DoorUpNoRigid : MonoBehaviour {

	public float openingHeight;
	private float startPosition, range;
	private GameObject door2;
	
	void Start () {
		startPosition = transform.position.y;
		door2 = GameObject.Find ("DoorUp");
		range = 3;
	}
	
	// Update is called once per frame
	public void Update(){

		if (ButtonPress.doorOpen > 0) {
			//door2.rigidbody.useGravity = false;
			if (door2.transform.position.y < startPosition + openingHeight) {
				door2.transform.Translate (Vector3.up * Time.deltaTime);
			}
		} else {
			if (door2.transform.position.y > startPosition + openingHeight) {
				door2.transform.Translate (Vector3.down * 3 * Time.deltaTime);
			}
		}
	}
}