using UnityEngine;
using System.Collections;

public class ToLevel2 : MonoBehaviour {
	
	public void OnTriggerEnter ()
	{
		Application.LoadLevel ("Level2");
	}
}