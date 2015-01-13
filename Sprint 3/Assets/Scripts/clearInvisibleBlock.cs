using UnityEngine;
using System.Collections;

public class clearInvisibleBlock : MonoBehaviour {

	public Transform BlockCoords;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			BlockCoords.localPosition = new Vector3(0,100f,0);
		}
	}
}
