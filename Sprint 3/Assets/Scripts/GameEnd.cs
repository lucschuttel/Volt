using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	
	public void OnTriggerEnter ()
	{
		Application.LoadLevel ("LevelDone");
	}
}