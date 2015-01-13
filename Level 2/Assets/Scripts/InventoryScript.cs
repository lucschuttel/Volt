using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour {

	public bool showInventory = true;
	public Texture2D keyIcon;
	public Texture2D extenderIcon;
	static List<string> inventoryContents = new List<string>();

	public static void AddItem(string identifier){
		inventoryContents.Add (identifier);
	}

	public static bool UseItem(string identifier){
		for(int i = 0; i < inventoryContents.Count; i++)
		{
			if(inventoryContents[i].Equals (identifier)){
				inventoryContents.RemoveAt (i);
				return true;
			}
		}
		return false;
	}

	void OnGUI() {

		GUIStyle myStyle = new GUIStyle();

		Font myFont = (Font)Resources.Load("Fonts/comic", typeof(Font));
		myStyle.font = myFont;
		myStyle.fontSize = 24;
		myStyle.normal.textColor = Color.white;

		Rect textArea = new Rect(Screen.width/4+50,(Screen.height*2)/3 + 106,180, 40);
		Rect boxArea =  new Rect(Screen.width/3+60,(Screen.height*2)/3+100 ,Screen.width/4, 40);
		Rect iconArea =  new Rect(Screen.width/3+80,(Screen.height*2)/3+73 ,60, 58);

		if (showInventory)
		{
			DrawBox(boxArea, new Color(0, 0, 0, 0.5f));
			GUI.Label (textArea, "Inventory", myStyle);
			for(int i = 0; i < inventoryContents.Count; i++)
			{
				iconArea = new Rect(Screen.width/3+80+i*60,(Screen.height*2)/3+73 ,60, 58);
				if (inventoryContents[i].Equals ("extender") )
					GUI.DrawTexture(iconArea, extenderIcon, ScaleMode.ScaleToFit, true, 0f);
				if (inventoryContents[i].Equals ("key") )
					GUI.DrawTexture(iconArea, keyIcon, ScaleMode.ScaleToFit, true, 0f);
			}
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
