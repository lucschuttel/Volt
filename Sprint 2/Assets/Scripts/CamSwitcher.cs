using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamSwitcher : MonoBehaviour {
	
	public Camera CameraRig;
	public Camera topdowncam;
	public int camcount;
	
	void Start () {
		
		Camera CameraRig = (Camera) GameObject.FindObjectOfType(typeof(Camera)); 
		Camera topdowncam = (Camera) GameObject.FindObjectOfType(typeof(Camera));
		int camcount = 0;
		CameraRig.enabled = true;
		topdowncam.enabled = false;
	}
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.C)) {
			camcount++;
			if (camcount == 0){
				CameraRig.enabled = !CameraRig.enabled;}
			else if (camcount ==1){
				topdowncam.enabled = !topdowncam.enabled;}
			if (camcount == 2) {
				camcount = 0;		
			}
		}
		
	}
}
