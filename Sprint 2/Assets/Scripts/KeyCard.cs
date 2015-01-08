using UnityEngine;
using System.Collections;

public class KeyCard : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			InventoryScript.AddItem("key");
			GameVariables.keyCount+=1;
			Destroy (gameObject);
		}
	}
}