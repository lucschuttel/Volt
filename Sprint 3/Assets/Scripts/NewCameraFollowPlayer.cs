using UnityEngine;
using System.Collections;

public class NewCameraFollowPlayer : MonoBehaviour {

	public Camera mainCamera;
	public Transform PlayerTransform;
	public bool ThirdPersonView = true;
	public Vector3 PlayerDistance;
	public Vector3 CameraRotation;
	private float newRotation;
	private float minDistance;
	public float maxDistance;
	private Vector3 zoomVector;

	void Start () {
		zoomVector = new Vector3 (0f, -0.1f, 0.2f);
		minDistance = PlayerDistance.magnitude;
		mainCamera.transform.localPosition = PlayerTransform.localPosition + PlayerDistance;
		mainCamera.transform.Rotate(CameraRotation);
	}

	void Update () {

		if (Input.GetAxis("Mouse ScrollWheel") != 0f) // forward
		{
			float MouseWheel = Input.GetAxis("Mouse ScrollWheel");

			if(MouseWheel > 0f && PlayerDistance.magnitude > minDistance)
				PlayerDistance = PlayerDistance + zoomVector;
			else if(MouseWheel < 0f && PlayerDistance.magnitude < maxDistance) PlayerDistance = PlayerDistance - zoomVector;

			if(PlayerDistance.magnitude < minDistance) PlayerDistance = PlayerDistance.normalized * minDistance;
			if(PlayerDistance.magnitude > maxDistance) PlayerDistance = PlayerDistance.normalized * maxDistance;
		}

		float rotateDegrees = PlayerMovementScript.locationRef;
		float rotateRadians = (rotateDegrees * Mathf.PI) / 180f;
		
		mainCamera.transform.RotateAround(Vector3.zero, Vector3.up, rotateDegrees);

		float sin = Mathf.Sin( rotateRadians );
		float cos = Mathf.Cos( rotateRadians );
		
		float transformX = PlayerDistance.x;
		float transformZ = PlayerDistance.z;
		
		PlayerDistance.x = (cos * transformX) + (sin * transformZ);
		PlayerDistance.z = (cos * transformZ) - (sin * transformX);

		transformX = zoomVector.x;
		transformZ = zoomVector.z;

		zoomVector.x = (cos * transformX) + (sin * transformZ);
		zoomVector.z = (cos * transformZ) - (sin * transformX);

		mainCamera.transform.localPosition = PlayerTransform.localPosition + PlayerDistance;
		
	}
}
