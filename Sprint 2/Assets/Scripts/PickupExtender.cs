using UnityEngine;
using System.Collections;

public class PickupExtender : MonoBehaviour {
	public Transform BlockCoords;
	public int LengthAddition = 10;

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			BlockCoords.localPosition = new Vector3(0,100f,0);
			QuickRope2.currentVelocity += LengthAddition;
			InventoryScript.AddItem("extender");
			Destroy (gameObject);
		}
	}
}