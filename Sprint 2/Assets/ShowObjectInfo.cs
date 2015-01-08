using UnityEngine;
using System.Collections;

public class ShowObjectInfo : MonoBehaviour {

	public string InfoContents="";
	public bool showDistance = false;
	private float distance = 0f;
	Rect textArea = new Rect(Screen.width/2,(Screen.height*2)/3 + 6,180, 40);
	Rect boxArea =  new Rect(0,(Screen.height*2)/3,Screen.width, 40);
	bool draw = false;

	// Update is called once per frame
	void Update () {
		draw = false;
		GameObject playerCopy = GameObject.FindWithTag ("Player");
		distance = Vector3.Distance (playerCopy.transform.position, this.transform.position);
		if (distance < 2.4f) {
				draw = true;
		}
	}
	void OnGUI() {

		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Fonts/comic", typeof(Font));
		myStyle.font = myFont;
		myStyle.fontSize = 24;
		myStyle.normal.textColor = Color.white;
		if (draw)
		{
			DrawBox(boxArea, new Color(0, 0, 0, 0.5f));
			if (showDistance)
				GUI.Label (textArea, InfoContents + "\ndist:" + distance, myStyle);
			else
				GUI.Label (textArea, InfoContents, myStyle);
		}
	}

	void DrawBox(Rect position, Color color) {
		Texture2D texture = new Texture2D(1, 1);
		texture.SetPixel(0,0,color);
		texture.Apply();
		GUI.skin.box.normal.background = texture;
		GUI.Box(position, GUIContent.none);
	}
}

