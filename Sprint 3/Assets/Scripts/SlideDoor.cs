using UnityEngine;
using System.Collections;

public class SlideDoor : MonoBehaviour {
	
	private bool doorOpen, pluggedIn;
	public float openingHeight;
	private float startPosition, range;
	private GameObject player, ropeEnd, door2;
	
	void Start () {
		startPosition = transform.position.y;
		player = GameObject.FindGameObjectWithTag ("Player");
		ropeEnd = GameObject.FindGameObjectWithTag ("RopeEnd");
		//door2 = transform.FindChild ("Door2").gameObject;
		door2 = GameObject.Find ("Door2");
		range = 3;
	}
	
	void PlayerCableAttach(){
		if (pluggedIn) {
			ropeEnd.transform.position = this.transform.position;
			ropeEnd.hingeJoint.connectedBody = this.rigidbody;
			
		} else {
			door2.rigidbody.useGravity = true;
			if(ropeEnd.hingeJoint.connectedBody != player.rigidbody){
				ropeEnd.hingeJoint.connectedBody = player.rigidbody;
			}
		}
	}
	
	void DoorAnimation(){
		if (doorOpen) {
			door2.rigidbody.useGravity = false;
			if (door2.transform.position.y < startPosition + openingHeight) {
				door2.transform.Translate (Vector3.up * Time.deltaTime);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t") && Vector3.Distance(player.transform.position, this.transform.position) < range) {
			pluggedIn = !pluggedIn;
			doorOpen = !doorOpen;
			PlayerCableAttach();
		}
		
		DoorAnimation ();
		
	}
}


/*   OLD VERSION


using UnityEngine;
using System.Collections;

public class SlideDoor : MonoBehaviour {
	
	private bool doorOpen, pluggedIn;
	public float openingHeight;
	private float startPosition, range;
	private GameObject player, ropeEnd, door2;
	
	void Start () {
		startPosition = transform.position.y;
		player = GameObject.FindGameObjectWithTag ("Player");
		ropeEnd = GameObject.FindGameObjectWithTag ("RopeEnd");
		door2 = transform.FindChild ("Door2").gameObject;
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
				door2.rigidbody.useGravity = false;
				if (door2.transform.position.y < startPosition + openingHeight) {
					door2.transform.Translate (Vector3.up * Time.deltaTime);
				}
			}
		} else {
			door2.rigidbody.useGravity = true;
			if(ropeEnd.hingeJoint.connectedBody != player.rigidbody){
				//ropeEnd.rigidbody.useGravity = false;
				ropeEnd.hingeJoint.connectedBody = player.rigidbody;
			}
		}
	}
}


*/