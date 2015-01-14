using UnityEngine;
using System.Collections;

public class ExtensionDoor : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player" && GameVariables.extension > 0) {
			InventoryScript.UseItem("extender");
			GameVariables.extension--;
			Destroy (gameObject);
		}
	}
}
