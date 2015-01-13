using UnityEngine;
using System.Collections;

public class SlideDoor : MonoBehaviour {

	private bool doorOpen;
	public float openingHeight;
	private float startPosition, range;
	private GameObject player;
	
	void Start () {
		startPosition = transform.position.y;
		player = GameObject.FindGameObjectWithTag ("Player");
		range = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("t") && Vector3.Distance(player.transform.position, this.transform.position) < range) {
			//pluggedIn = !pluggedIn;
			doorOpen = !doorOpen;
			}

		if (doorOpen) {
			rigidbody.useGravity = false;
			range = 5;
			if (transform.position.y < startPosition + openingHeight) {
					transform.Translate (Vector3.up * Time.deltaTime);
			}
		} else {
			rigidbody.useGravity = true;
			range = 10;
		}
	}
}
