using UnityEngine;
using System.Collections;

public class LampOnOff : MonoBehaviour {
	public Object target;
	public GameObject source;
	public int lampNummer = 1;
	private Transform transPlayer;
	private Transform transLamp;
	private bool tPressed = false;

	// Use this for initialization
	void Start () {
		transPlayer = GameObject.FindGameObjectWithTag ("Player").transform;
		transLamp = GameObject.FindGameObjectWithTag ("Licht"+lampNummer.ToString()).transform;
	}
	
	// Update is called once per frame
	void Update () {
		transPlayer = GameObject.FindGameObjectWithTag ("Player").transform;
		transLamp = GameObject.FindGameObjectWithTag ("Licht"+lampNummer.ToString()).transform;

		Object currentTarget = target != null ? target : gameObject;
		Behaviour targetBehaviour = currentTarget as Behaviour;
		GameObject targetGameObject = currentTarget as GameObject;

		if (Input.GetKeyDown(KeyCode.T) && Vector3.Distance(transPlayer.position, transLamp.position) < 3)
		{
			tPressed = true;
		}

		if (Vector3.Distance(transPlayer.position, transLamp.position) < 3)
	    {
			if (targetGameObject.activeSelf == true && !Input.GetKeyDown(KeyCode.T) && tPressed)
			{
				targetGameObject.SetActive(false);
				tPressed = false;
			}
			else if(targetGameObject.activeSelf == false && !Input.GetKeyDown(KeyCode.T) && tPressed)
			{
				targetGameObject.SetActive(true);
				tPressed = false;
			}
		}
	}
}
