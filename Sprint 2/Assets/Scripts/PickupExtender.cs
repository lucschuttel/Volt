using UnityEngine;
using System.Collections;

public class PickupExtender : MonoBehaviour {

	public int LengthAddition = 10;
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			QuickRope2.currentVelocity += LengthAddition;
			InventoryScript.AddItem("extender");
			Destroy (gameObject);
		}
	}
}