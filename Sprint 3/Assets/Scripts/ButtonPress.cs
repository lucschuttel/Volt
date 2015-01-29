using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {
	
	public static int doorOpen;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "box") {
			Destroy (gameObject);
			doorOpen =+ 1;
		}
	}
}
