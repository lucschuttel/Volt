using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	Vector3 playerPos;
	GameObject player;
	int range = 3;

	public Light Light;
	public GameObject goLightSwitch;
	
	public AudioClip SwitchOn;
	
	private bool _switchOn;
	private GameObject _upPosition;
	private GameObject _downPosition;
	
	private AudioSource _audioSource;
	
	void Awake()
	{
		_upPosition = GameObject.Find ("UpPosition");
		_downPosition = GameObject.Find ("DownPosition");
		_audioSource = gameObject.GetComponentInChildren<AudioSource> ();

		player = GameObject.FindGameObjectWithTag ("Player");

		Light.enabled = false;
	}

	void Update () {
		//zorgt ervoor dat de positie van de switch naar boven gezet wordt

		playerPos = player.transform.position;
		
		if (Vector3.Distance (playerPos, this.transform.position) < range) {
			if (Input.GetKeyDown ("t") && !_switchOn){

					_switchOn = true;
					goLightSwitch.transform.position = new Vector3(goLightSwitch.transform.position.x,
					                                               _upPosition.transform.position.y,
					                                               goLightSwitch.transform.position.z);
					
					Light.enabled = true;
					_audioSource.clip = SwitchOn;
					_audioSource.Play();

					Destroy(GameObject.Find("LightWall"));
				}
		}
	}
}
