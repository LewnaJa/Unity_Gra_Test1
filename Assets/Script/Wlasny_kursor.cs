using UnityEngine;
using System.Collections;

public class Wlasny_kursor : MonoBehaviour 
{
	public Texture2D cursorTexture; 
	private int cursorSizeX = 32;
	private int cursorSizeY = 32;
	
	void Start()
	{
		Screen.lockCursor = false;
		Cursor.visible = false;
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x, (Screen.height - Input.mousePosition.y), cursorSizeX, cursorSizeY), cursorTexture);
	}
}
