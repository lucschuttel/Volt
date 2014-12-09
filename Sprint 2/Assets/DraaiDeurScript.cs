using UnityEngine;
using System.Collections;

public class DraaiDeurScript : MonoBehaviour {

	private bool open = false;
	public bool locked = false;
	private float distance;

	public GameObject lockComponent;

	void Start(){
		if(locked) lockComponent.transform.renderer.materials[1].color = Color.red;
	}
	// Update is called once per frame
	void Update () {

		GameObject playerCopy = GameObject.FindWithTag ("Player");
		distance = Vector3.Distance (playerCopy.transform.position, this.transform.position);

		if (distance < 2.4f && Input.GetKeyDown ("t")) {
			if(locked){
				if(InventoryScript.UseItem("key")) {
					locked = false;
					lockComponent.transform.renderer.materials[1].color = Color.green;
				}
			}
			if(!locked){
				open = !open;
				if(open){
					//rotate the door to open from middle
					transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y+90, transform.eulerAngles.z);
					transform.position = new Vector3(transform.localPosition.x-1, transform.localPosition.y, transform.localPosition.z-1);
				}
				else {
					//rotate the door to closed from middle
					transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y-90, transform.eulerAngles.z);
					transform.position = new Vector3(transform.localPosition.x+1, transform.localPosition.y, transform.localPosition.z+1);
				}
			}
		}

	}
}
