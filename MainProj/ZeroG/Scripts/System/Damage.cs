using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
	private static float playerDamage;
	

	public static float addglobalDamage(float dmg)
	{
		playerDamage = dmg;
		return playerDamage;
	}

	public static float showDamage()
	{
		return playerDamage;
	}
}

