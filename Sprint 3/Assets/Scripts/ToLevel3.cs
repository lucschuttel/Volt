using UnityEngine;
using System.Collections;

public class ToLevel3 : MonoBehaviour {

	public void OnTriggerEnter ()
	{
		Application.LoadLevel ("Level3");
	}
}