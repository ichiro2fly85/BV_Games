using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {


	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}

	public static string CurrentNinja{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static int ExperiencePoints{ get; set; }
	public static int MaxHP{ get; set; }
	public static int AttackPoints{ get; set; }
	public static int DefensePoints{ get; set; }






	
}

