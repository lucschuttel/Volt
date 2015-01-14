using UnityEngine;
using System.Collections;

public class SlideDoor : MonoBehaviour {
	
	private bool doorOpen, pluggedIn;
	public float openingHeight;
	private float startPosition, range;
	private GameObject player, ropeEnd, door;
	
	void Start () {
		startPosition = transform.position.y;
		player = GameObject.FindGameObjectWithTag ("Player");
		ropeEnd = GameObject.FindGameObjectWithTag ("RopeEnd");
		door = transform.FindChild ("Door").gameObject;
		range = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t") && Vector3.Distance(player.transform.position, this.transform.position) < range) {
			pluggedIn = !pluggedIn;
			doorOpen = !doorOpen;
		}
		
		if (pluggedIn) {
			ropeEnd.transform.position = this.transform.position;
			ropeEnd.hingeJoint.connectedBody = this.rigidbody;
			
			if (doorOpen) {
				door.rigidbody.useGravity = false;
				if (door.transform.position.y < startPosition + openingHeight) {
					door.transform.Translate (Vector3.up * Time.deltaTime);
				}
			}
		} else {
			door.rigidbody.useGravity = true;
			ropeEnd.rigidbody.useGravity = false;
			ropeEnd.hingeJoint.connectedBody = player.rigidbody;
		}
	}
}