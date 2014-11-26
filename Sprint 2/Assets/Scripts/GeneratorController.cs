using UnityEngine;
using System.Collections;

public class GeneratorController : MonoBehaviour {

	GameObject player, camera;
	Vector3 playerPos, cameraPos;
	int range, angle;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		range = 2;
		angle = 80;
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = player.transform.position;
		cameraPos = camera.transform.position;

		if(Vector3.Distance(playerPos, this.transform.position) < range)
		{
			if (Input.GetKey ("t")) {
					Application.LoadLevel("LevelDone");
			}
		}
	}
}


