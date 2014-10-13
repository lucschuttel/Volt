using UnityEngine;
using System.Collections;

public class PlayerBehaviourScript : MonoBehaviour {

	public bool moving = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Movement();
	}

	void Movement (){
		if (Input.GetKey("d")) {
			transform.Translate (Vector3.right * 7f * Time.deltaTime);
		}

		if (Input.GetKey("a")) {
			transform.Translate (Vector3.left * 7f * Time.deltaTime);
		}

		if (Input.GetKey("w")) {
			transform.Translate (Vector3.forward * 7f * Time.deltaTime);
		}

		if (Input.GetKey("s")) {
			transform.Translate (Vector3.back * 7f * Time.deltaTime);
		}

		//transform.eulerAngles.Set(0f,0f,0f);
	}
}
