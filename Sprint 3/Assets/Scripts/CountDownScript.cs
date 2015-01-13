using UnityEngine;
using System.Collections;

public class CountDownScript : MonoBehaviour {
	public static float triggerTime = 10f;

	void Start() {
		triggerTime = 10f;
	}
	// Update is called once per frame
	void Update () {
		triggerTime -= Time.deltaTime;
		if(triggerTime < 0f) Application.LoadLevel("MenuScreen");
	}
}
