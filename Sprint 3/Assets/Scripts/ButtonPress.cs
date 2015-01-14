using UnityEngine;
using System.Collections;

public class ButtonPress : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Box") {
			Destroy (gameObject);
		}
	}
}
