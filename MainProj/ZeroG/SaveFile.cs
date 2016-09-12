using UnityEngine;
using System.Collections;

public class SaveFile {



	public static void SaveAllInformation(){

		PlayerPrefs.SetString("CURRENTNINJA", Global.CurrentNinja);
		PlayerPrefs.SetInt("PLAYERLEVEL", Global.PlayerLevel);
		PlayerPrefs.SetInt ("EXP", Global.ExperiencePoints);
		PlayerPrefs.SetInt ("MAXHEALTHPOINTS", Global.MaxHP);
		PlayerPrefs.SetInt ("ATTACKPOINTS", Global.AttackPoints);
		PlayerPrefs.SetInt ("DEFENSEPOINTS", Global.DefensePoints);





	}




}

