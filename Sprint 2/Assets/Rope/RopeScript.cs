using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RopeScript : MonoBehaviour {

	public InteractiveCloth cloth;
	public ClothRenderer clothRender;
	//public Collider collider;
	public Mesh ropeMesh;
	public Material material;

	public GameObject PlayerObject;

	public List<GameObject> ropeList;

	GameObject player;
	// Use this for initialization

	void Start () {

				GameObject ropePrimitive = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
				player = GameObject.FindGameObjectWithTag ("Player");
				//gameObject.AddComponent<InteractiveCloth> ().mesh = ropePrimitive.GetComponent<MeshFilter>().mesh;
				gameObject.AddComponent<InteractiveCloth> ().mesh = ropeMesh;
				Destroy (ropePrimitive);
		gameObject.AddComponent<HingeJoint> ();
		rigidbody.hingeJoint.connectedBody = PlayerObject.rigidbody;
		//transform.GetComponent<InteractiveCloth> ().AttachToCollider (PlayerObject.rigidbody.collider, false, true);
				transform.GetComponent<InteractiveCloth> ().density = 1;
				transform.GetComponent<InteractiveCloth> ().pressure = 1;
				transform.GetComponent<InteractiveCloth> ().tearFactor = 0;
				transform.GetComponent<InteractiveCloth> ().thickness = 0.0016f;
				transform.GetComponent<InteractiveCloth> ().bendingStiffness = 1.0f;
				transform.GetComponent<InteractiveCloth> ().stretchingStiffness = 1.0f;
				transform.GetComponent<InteractiveCloth> ().attachmentResponse = 0.5f;
				transform.GetComponent<InteractiveCloth> ().friction = 0.0f;
				GetComponent<InteractiveCloth>().selfCollision = false;
				gameObject.AddComponent<ClothRenderer> ().material = material;

		}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = player.transform.position;
		//playerPos = player.transform.position;
	}
}
