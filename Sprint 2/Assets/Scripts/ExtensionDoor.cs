using UnityEngine;
using System.Collections;

public class ExtensionDoor : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && GameVariables.extension > 0) {
			GameVariables.extension--;
			Destroy (gameObject);
		}
	}
}
