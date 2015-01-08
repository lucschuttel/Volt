using UnityEngine;
using System.Collections;

public class LevelEndCollideScript : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			if(menuScript.currentLevel == 1) menuScript.level1State = "cleared";
			Application.LoadLevel("LevelDone");
		}
	}
}
