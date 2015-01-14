using UnityEngine;
using System.Collections;

public class ExtensionCord : MonoBehaviour {
	
	void OnTriggerEnter(Collider collider){
<<<<<<< HEAD
		if (collider.gameObject.tag == "Player"){
			InventoryScript.AddItem("extender");
=======
		if (collider.gameObject.name == "Player"){
>>>>>>> origin/Level-2
			GameVariables.extension+=1;
			Destroy (gameObject);
		}
	}
}