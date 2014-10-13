using UnityEngine;
using System.Collections;

public class CameraBehaviourScript : MonoBehaviour {
	
	public GameObject target;					//the target object
	private float speedMod = 10.0f;				//a speed modifier
	private Vector3 point;						//the coord to the point where the camera looks at
	private bool moving = false;
	
	void Start () {
		moving = false;
	}
	
	void Update () {
		point = target.transform.position;		//get target's coords
		transform.LookAt(point);				//makes the camera look to it

		if (Input.GetKey ("a") || Input.GetKey ("s") || Input.GetKey ("d") || Input.GetKey ("w")) {
			moving = true;
		} else {
			moving = false;
		}

		Rotate ();
	}

	void Rotate () {							//makes the camera rotate around "point" coords, rotating around its Y axis, 25 degrees per second times the speed modifier
		if (Input.GetKey ("left") && moving == false) {
			transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), 25 * Time.deltaTime * speedMod);
		} else if (Input.GetKey ("right") && moving == false) {
			transform.RotateAround (point, new Vector3 (0.0f, 1.0f, 0.0f), -25 * Time.deltaTime * speedMod);
		}
	}
}