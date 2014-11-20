using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

	GameObject player;
	Vector3 playerPos;
	int range;
	bool pluggedIn;
	private bool doorOpen;
	private Light[] lights;
	private GameObject[] doors;
	public string switchType;
	public GameObject lightParent;
	public string doorTag;
	public int doorOpeningHeight;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		range = 3;
		pluggedIn = false;
		doorOpen = false;

		if (switchType == "Light" && lightParent != null) {
			lights = lightParent.GetComponentsInChildren<Light> (true);
			
			foreach (Light light in lights) 
			{
				light.enabled = false;
			}
		}

		if (switchType == "Door" && doorTag != null) {
			doors = GameObject.FindGameObjectsWithTag(doorTag);
		}
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = player.transform.position;

		if(Vector3.Distance(playerPos, this.transform.position) < range)
		{

			if (switchType == "Light"){
				if (Input.GetKeyDown ("t") && (GameVariables.playerHasPower || pluggedIn)) {
					pluggedIn = !pluggedIn;
					SwitchLights();
				}
			}
			
			if (switchType == "Door"){
				if (Input.GetKeyDown ("t") && (GameVariables.playerHasPower || pluggedIn)) {
					pluggedIn = !pluggedIn;
					doorOpen = !doorOpen;
				}
			
				if (doorOpen){
					foreach (GameObject door in doors){
						door.rigidbody.useGravity = false;
					}
					SwitchDoor();
				} else {
					foreach (GameObject door in doors){
						door.rigidbody.useGravity = true;
					}
				}
			}
		}
	}

	void SwitchLights () {
		foreach (Light light in lights) 
		{
			light.enabled = !light.enabled;
			GameVariables.playerHasPower = !GameVariables.playerHasPower;
		}
	}

	void SwitchDoor(){
		foreach (GameObject door in doors) {
			if (doorOpeningHeight != null && (door.transform.position.y - door.transform.localScale.y / 2) < doorOpeningHeight) {
				door.transform.Translate(Vector3.up * Time.deltaTime);
			}
		}
	}
}