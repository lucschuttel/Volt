using UnityEngine;
using System.Collections;

public class SleutelScript : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			InventoryScript.AddItem("key");
			Destroy (gameObject);
		}
	}
}