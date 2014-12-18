using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {

	public float walkingSpeed = 5;
	//public float rotationSpeed = 3;
	private Vector2 mousePosition;
	public static float locationRef = 0f;
	public static bool moving = false;
	private bool onGround = false;
	public float JumpHeight;

	void Start () {
		mousePosition = new Vector2 (0, 0);	
	}

	void OnMouseUp() {
		locationRef = 0f;
	}

	void OnMouseDrag() {
		Vector2 newMousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 mouseDifference = (Vector2.zero - mousePosition) + newMousePosition;

		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + mouseDifference.x/2f, transform.eulerAngles.z);
		locationRef = mouseDifference.x/2f;
	}

	void Update () {

		Vector3 direction = new Vector3 (0, 0, 0);

		if(Input.GetKey("w")) { 
			direction = direction + Vector3.left;
		}
		if(Input.GetKey("s")) {
			direction = direction + Vector3.right;
		}
		if(Input.GetKey("a")){
			direction = direction + Vector3.back;
		}
		if(Input.GetKey("d")){
			direction = direction + Vector3.forward;
		}

		direction.Normalize ();
		direction *= Time.deltaTime * walkingSpeed;
		transform.Translate(direction);

		if(!onGround && rigidbody.velocity.y < 0.01 && rigidbody.velocity.y > -0.01) {
			onGround = true;
		}
		if (Input.GetKeyDown("space") && onGround == true) {
			rigidbody.velocity = new Vector3(0, JumpHeight, 0);
			onGround = false;
		}

		mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
	}
}
