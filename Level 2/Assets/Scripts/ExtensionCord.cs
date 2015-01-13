using UnityEngine;
using System.Collections;

public class ExtensionCord : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player"){
			GameVariables.extension+=1;
			Destroy (gameObject);
		}
	}
}