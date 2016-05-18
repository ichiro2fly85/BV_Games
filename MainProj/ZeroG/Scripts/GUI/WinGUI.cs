using UnityEngine;
using System.Collections;

public class WinGUI : MonoBehaviour {

	// Use this for initialization
	private static GUIText myText;


	void Start () 
	{
		myText = GetComponent<GUIText> ();
		myText.enabled = false;
	
	}

	public static void cleared()
	{
		myText.enabled = true;
	}

}
