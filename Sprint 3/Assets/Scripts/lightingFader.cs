using UnityEngine;
using System.Collections;

public class lightingFader : MonoBehaviour {

	void Update () {
		light.intensity = CountDownScript.triggerTime/2;
	}
}
