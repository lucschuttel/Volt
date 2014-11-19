using UnityEngine;
using System.Collections;

public class KeyItem : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Beta"){
			GameVariables.keyCount+=2;
			Destroy (gameObject);
		}
	}
}