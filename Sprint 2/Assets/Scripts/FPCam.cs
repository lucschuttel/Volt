using UnityEngine;
using System.Collections;
//using UnityEditor;

public class FPCam : MonoBehaviour {
	private Transform transPlayer;
	private Transform transCamera;
	private Component hetScript;
	private GameObject deCamera;
	private bool yPressed;
	public Vector3 posCamera;
	// Use this for initialization
	void Start () {
		transPlayer = GameObject.FindGameObjectWithTag ("Player").transform;
		transCamera = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		deCamera = GameObject.FindGameObjectWithTag ("MainCamera");
		posCamera = new Vector3(0, 1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transCamera.position = transPlayer.position + posCamera;
		transCamera.rotation = transPlayer.rotation;

		yPressed = Input.GetKey(KeyCode.Y);

		if (yPressed && deCamera.GetComponent<FPCam> ().enabled == true)
		{
			deCamera.GetComponent<FPCam> ().enabled = false;
			deCamera.GetComponent<ThirdPersonCamera> ().enabled = true;
		}

		/*if (yPressed && deCamera.GetComponent<FPCam> ().enabled == false)
		{
			deCamera.GetComponent<FPCam> ().enabled = true;
		}*/
	}
}
