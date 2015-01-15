using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {
	
	GameObject player;
	Vector3 playerPos;
	int range;
	bool pluggedIn;
	private Light[] lights;
	public GameObject lightParent;
	public GameObject targetObject;

	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		range = 3;
		pluggedIn = false;
		
		lights = lightParent.GetComponentsInChildren<Light> (true);
		foreach (Light light in lights) 
		{
			light.enabled = false;
		}
		targetObject.active = false;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = player.transform.position;
		
		if(Vector3.Distance(playerPos, this.transform.position) < range)
		{
			
			if (Input.GetKeyDown ("t") /* && (GameVariables.playerHasPower)*/) {
				pluggedIn = !pluggedIn;
				SwitchLights();
			}
			
		}
	}
	
	void SwitchLights () {
		foreach (Light light in lights) 
		{
			light.enabled = !light.enabled;
			/* GameVariables.playerHasPower = !GameVariables.playerHasPower; */
		}
		targetObject.active = !targetObject.active;
	}
	
}
