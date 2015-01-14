using UnityEngine;
using System.Collections;

public class ExtensionCord : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player"){
			InventoryScript.AddItem("extender");
			GameVariables.extension+=1;
			Destroy (gameObject);
		}
	}
}