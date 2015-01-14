using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamSwitcher : MonoBehaviour {
	
	public Camera CameraRig;
	public Camera topdowncam;
	public int camcount, roofObjectCount;
	public GameObject roofObject1; 
	public GameObject roofObject2;
	public GameObject roofObject3;
	
	void Start () {
		
		Camera CameraRig = (Camera) GameObject.FindObjectOfType(typeof(Camera)); 
		Camera topdowncam = (Camera) GameObject.FindObjectOfType(typeof(Camera));
		int camcount = 0;
		CameraRig.enabled = true;
		topdowncam.enabled = false;
		roofObject1.active = true;
		roofObject2.active = true;
		roofObject3.active = true;
	}
	
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.C)) {
			camcount++;
			if (camcount == 0){
				CameraRig.enabled = true;
				topdowncam.enabled = false;
				roofObject1.active = true; roofObject2.active = true; roofObject3.active = true;
			}
			if (camcount == 1){
				topdowncam.enabled = true;
				CameraRig.enabled = false;
				roofObject1.active = false; roofObject2.active = false;	roofObject3.active = false;
			}
			if (camcount == 2) {
				camcount = -1;		
			}
			
		}
		
	}
}
