using UnityEngine;
using System.Collections;

public class LightWall : MonoBehaviour {
	public Light Light;


	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Player" && Light.enabled == true){//&& GameVariables.light > 0) {
			Destroy (gameObject);
		}
	}
}
