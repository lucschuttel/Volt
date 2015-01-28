using UnityEngine;
using System.Collections;

public class FloorButtonScript : MonoBehaviour {

	public Material material;
	
	private bool turnedOn;
	private GameObject floorButton;


	void Start () {
		turnedOn = false;
		floorButton = transform.Find("polySurface2").gameObject;
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "box") {
			    SetButtonStatus(true);
		}
	}

	void OnTriggerExit(Collider collider){
		if (collider.gameObject.name == "box") {
			SetButtonStatus(false);
		}
	}

	void SetButtonStatus(bool status){
		if(status) {
			turnedOn = true;
			//material.SetColor ("_SpecColor", Color.green);
			floorButton.renderer.material.color = Color.green;

		} else {
			turnedOn = false;
			floorButton.renderer.material.color = Color.red;
		}
	}

	// Update is called once per frame
	void Update () {
		//SetButtonStatus (false);
	}
}
