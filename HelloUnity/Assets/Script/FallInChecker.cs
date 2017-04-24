using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInChecker : MonoBehaviour {

	public Hole red;
	public Hole blue;
	public Hole green;

	public GUIStyleState styleState;
	private GUIStyle style;

	// Use this for initialization
	void Start()
	{
		style = new GUIStyle();
		style.fontSize = 50;
		style.fontStyle = FontStyle.BoldAndItalic;
	}

	void OnGUI()
	{


		string label = " ";

		if (red.IsFallIn() && blue.IsFallIn() && green.IsFallIn())
		{
			label = "Congratulations!";
		}
		Rect rect = new Rect(280, 100, 500, 500);

		GUI.Label(rect, label, style);
	}
			
	// Update is called once per frame
	void Update () {
		
	}
}
