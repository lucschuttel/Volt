using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

	private GameObject player;
	private int range;
	private bool pickedUp;
	private Vector3 posDifference;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		range = 2;
		pickedUp = false;

		collider.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPos = player.transform.position;

		if (Input.GetKeyDown ("t") && Vector3.Distance(playerPos, this.transform.position) < range) {
			pickedUp = !pickedUp;
			posDifference = this.transform.position - player.transform.position;
		}

		if (pickedUp){
			this.transform.position = player.transform.position + posDifference;
			rigidbody.useGravity = false;
			rigidbody.isKinematic = true;
		} else {
			rigidbody.useGravity = true;
			rigidbody.isKinematic = false;
		}
	}
}