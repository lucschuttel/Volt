using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Texture2D gameLogo;
	private string menuState = "main";
	private int selected = 0;

	public static int currentLevel = 0;
	public static string level1State = "open";
	public static string level2State = "locked";
	public static string level3State = "locked";

	Rect logoArea =  new Rect(40,30 ,461, 209);
	GUIStyle myStyle = new GUIStyle();
	
	Font myFont = (Font)Resources.Load("Fonts/comic", typeof(Font));


	void Update(){
		currentLevel = 0;
		if ((Input.GetKeyUp ("space") || Input.GetKeyDown ("d")) && menuState.Equals ("main")){
			if(selected == 0) { menuState = "level"; selected = 0; }
			if(selected == 3) Application.Quit();
		}
		if (Input.GetKeyDown ("space") && menuState.Equals ("level")){
			if(selected == 0) { currentLevel = 1; Application.LoadLevel("Sprint2");}
			if(selected == 1 && (level2State.Equals ("cleared") || level2State.Equals ("open")) ) Application.LoadLevel("Sprint2");
			if(selected == 2 && (level3State.Equals ("cleared") || level3State.Equals ("open")) ) Application.LoadLevel("Sprint2");		
		}

		if ((Input.GetKeyUp ("a") || Input.GetKeyUp ("left")) && !menuState.Equals ("main") ){
			menuState = "main";
		}

		if((Input.GetKeyDown ("up") || Input.GetKeyDown ("w")))
			selected -=1;

		if((Input.GetKeyDown ("down") || Input.GetKeyDown ("s")))
			selected +=1;

		if(selected > 2 && menuState.Equals ("level")) selected = 0;
		if(selected < 0 && menuState.Equals ("level")) selected = 2;
		if(selected > 3 && menuState.Equals ("main")) selected = 0;
		if(selected < 0 && menuState.Equals ("main")) selected = 3;
	}

	// Update is called once per frame
	void OnGUI () {

		myStyle.font = myFont;
		myStyle.fontSize = 24;
		myStyle.normal.textColor = Color.white;

		Rect textArea = new Rect(100,260,180, 40);
		Rect textArea1 = new Rect(100,260,180, 40);
		Rect textArea2 = new Rect(100,290,180, 40);
		Rect textArea3 = new Rect(100,320,180, 40);
		Rect textArea4 = new Rect(100,350,180, 40);
		Rect sectArea = new Rect(80, 260 + selected*30, 180, 40);

		GUI.DrawTexture (logoArea, gameLogo, ScaleMode.ScaleToFit, true, 0f);

		if(menuState.Equals ("main")){
			GUI.Label (textArea1, "Play Volt!", myStyle);
			GUI.Label (textArea2, "User options", myStyle);
			GUI.Label (textArea3, "About the makers", myStyle);
			GUI.Label (textArea4, "Exit application", myStyle);
		}

		if(menuState.Equals ("level")){
			drawLevelInfo(textArea1, myStyle, level1State, "level 1");
			drawLevelInfo(textArea2, myStyle, level2State, "level 2");
			drawLevelInfo(textArea3, myStyle, level3State, "level 3");
		}

		GUI.Label (sectArea, ">", myStyle);
	}

	void drawLevelInfo(Rect location, GUIStyle style, string type, string message=""){
		GUI.Label (location, message, style);
		if(type.Equals ("locked")){
			style.normal.textColor = Color.red;
			GUI.Label (location, "\t\t\t\t\t\tLOCKED", style);
			style.normal.textColor = Color.white;
		}
		else if(type.Equals ("open")){
			style.normal.textColor = Color.Lerp(Color.yellow, Color.red, 0.5f); 
			GUI.Label (location, "\t\t\t\t\t\tOPEN", style);
			style.normal.textColor = Color.white;
		}
		else if(type.Equals ("cleared")){
			style.normal.textColor = Color.green; 
			GUI.Label (location, "\t\t\t\t\t\tCLEARED", style);
			style.normal.textColor = Color.white;
		}
	}
}
