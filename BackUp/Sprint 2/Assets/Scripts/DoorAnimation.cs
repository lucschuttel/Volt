using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour {
	
	int speedOpen = 1000;
	Vector3 playerPos;
	int range = 3;
	GameObject player;
	public int doorAngle;
	private bool doorOpening, doorOpen;
	private float completedRotation;
	public GameObject door;
	public int rotationSpeed;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		doorOpen = false;
	}
	
	void Update () {
		playerPos = player.transform.position;
		
		if (Vector3.Distance (playerPos, this.transform.position) < range) {
			if (Input.GetKeyDown ("t") && (GameVariables.keyCount > 0)) {
				doorOpening = !doorOpening;
			}
		}
		
		if (doorOpening) {
			//Turning the door with rotationspeed, completed rotation houd bij hoe far de door has geturned.
			door.transform.Rotate(0,rotationSpeed,0);
			completedRotation += rotationSpeed;
			//Voor negatieve en positieve rotationspeed, de deur niet meer open laten gaan en de deur is dan open.
			if (rotationSpeed >= 0){
				if (completedRotation >= doorAngle){
					doorOpening = !doorOpening;
					doorOpen = !doorOpen;
				}
			} else {
				if (completedRotation <= doorAngle){
					doorOpening = !doorOpening;
					doorOpen = !doorOpen;
				}
			}
		}
	}
}