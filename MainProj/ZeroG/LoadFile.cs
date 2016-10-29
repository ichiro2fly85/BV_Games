using UnityEngine;
using System.Collections;

public class LoadFile {



	public static void LoadAllInformation(){

		Global.CurrentNinja = PlayerPrefs.GetString ("CURRENTNINJA");
		Global.PlayerLevel = PlayerPrefs.GetString ("PLAYERLEVEL");
		Global.ExperiencePoints = PlayerPrefs.GetString ("EXP");
		Global.MaxHP = PlayerPrefs.GetString ("MAXHEALTHPOINTS");
		Global.AttackPoints = PlayerPrefs.GetString ("ATTACKPOINTS");
		Global.DefensePoints = PlayerPrefs.GetString ("DEFENSEPOINTS");
		Global.TechPoints = PlayerPrefs.GetString ("TECHNIQUEPOINTS");







	}




}

