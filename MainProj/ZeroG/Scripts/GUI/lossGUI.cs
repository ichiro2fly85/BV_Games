using UnityEngine;
using System.Collections;

public class lossGUI : MonoBehaviour {

	private static GUIText myText;
	
	
	void Start () 
	{
		myText = GetComponent<GUIText> ();
		myText.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Damage.showDamage() == 100.0)
		{
			myText.enabled = true;
			Player.frozen(true);

		}

	}
}
