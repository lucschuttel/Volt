using UnityEngine;
using System.Collections;

public class ElevatorDoor : MonoBehaviour {

	private GameObject liftDoorLeft, liftDoorRight, player, ropeEnd;
	private float doorstartright, doorstartleft, range;
	private bool doorOpen;

	void Start () {
		doorOpen = false;
		liftDoorLeft = GameObject.FindGameObjectWithTag ("Liftdoor_Left");
		doorstartleft = liftDoorLeft.transform.position.z;
		liftDoorRight = GameObject.FindGameObjectWithTag ("Liftdoor_Right");
		doorstartright = liftDoorRight.transform.position.z;
		player = GameObject.FindGameObjectWithTag ("Player");
		range = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t") && Vector3.Distance (player.transform.position, this.transform.position) < range) {
			doorOpen = !doorOpen;
			PlugIn();
		}

		if (doorOpen) {
			if (liftDoorLeft.transform.position.z >= doorstartleft + 1f)
				liftDoorLeft.transform.Translate (0, 0, 0);
			else 
				liftDoorLeft.transform.Translate(0,0,0.1f);
			
			if (liftDoorRight.transform.position.z <= doorstartright - 1)
				liftDoorRight.transform.Translate (0, 0, 0);
			else 
				liftDoorRight.transform.Translate(0,0,-0.1f);
		}
	}

	void PlugIn(){
		ropeEnd = GameObject.FindGameObjectWithTag ("RopeEnd");
		ropeEnd.transform.position = this.transform.position;
		//GameVariables.pluggedIn = true;
	}
}
