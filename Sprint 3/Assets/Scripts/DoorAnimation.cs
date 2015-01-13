using UnityEngine;
using System.Collections;

public class DoorAnimation : MonoBehaviour {
	
	int speedOpen = 1000;
	Vector3 playerPos;
	int range = 3;
	GameObject player;
	public int doorAngle = -90;
	private bool doorOpening, doorOpen;
	private float completedRotation;
	public GameObject door;
	public int rotationSpeed = -5;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		doorOpen = false;
	}
	
	void Update () {
		playerPos = player.transform.position;
		
		if (Vector3.Distance (playerPos, this.transform.position) < range) {
			if (Input.GetKeyDown ("t")) {
					doorOpening = !doorOpening;
				}
			}
			
			if (doorOpening) {
				//Deur draaien met rotationSpeed, completedRotation houdt bij hoe ver de deur heeft gedraaid.
				door.transform.Rotate(0,rotationSpeed,0);
				completedRotation += rotationSpeed;
				//Als de rotatie groter is dan de angle van de deur, stopt de deur met draaien
				
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