using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Texture2D gameLogo;
	Rect logoArea =  new Rect(40,30 ,461, 209);

	GUIStyle myStyle = new GUIStyle();
	
	Font myFont = (Font)Resources.Load("Fonts/comic", typeof(Font));


	void Update(){
		if (Input.GetKeyDown ("space"))
			Application.LoadLevel("Sprint2");
		}
	// Update is called once per frame
	void OnGUI () {
		myStyle.font = myFont;
		myStyle.fontSize = 24;
		myStyle.normal.textColor = Color.white;
		Rect textArea = new Rect(100,260,180, 40);
		GUI.DrawTexture (logoArea, gameLogo, ScaleMode.ScaleToFit, true, 0f);
		GUI.Label (textArea, "Press SPACE to start game", myStyle);
	}
}
