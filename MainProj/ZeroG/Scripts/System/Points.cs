using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

	private static float playerPoints;

	public static float addglobalPoints(float points)
	{
		playerPoints = points;
		return playerPoints;
	}
	
	public static float showPoints()
	{
		return playerPoints;
	}
}
