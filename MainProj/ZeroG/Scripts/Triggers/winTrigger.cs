using UnityEngine;
using System.Collections;

public class winTrigger : MonoBehaviour {
	


	void OnTriggerEnter2D(Collider2D obj)
	{

		if(obj.tag == "Player")
		{
			WinGUI.cleared();
			Player.frozen(true);
		}
	}


}
