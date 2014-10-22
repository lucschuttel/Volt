using UnityEngine;
using System.Collections;

public class KeyDoor : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && GameVariables.keyCount > 0) {
						GameVariables.keyCount--;
						Destroy (gameObject);
				}
	}
}
