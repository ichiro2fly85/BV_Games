using UnityEngine;
using System.Collections;

public class GameSystem : MonoBehaviour 
{
	public void ChangeLevel(string pLevelName)
	{
		Application.LoadLevel(pLevelName);
	}
}