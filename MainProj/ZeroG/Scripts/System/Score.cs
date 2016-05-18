using UnityEngine;
using System.Collections;

//Score Gui script

public class Score : MonoBehaviour 
{
	private GUIText DamageText;
	private float pDamage;


	void Awake()
	{
		DamageText = GetComponent<GUIText>();
	}
	
	void Update()
	{	

		pDamage = Damage.showDamage();
		DamageText.text = "Damage %: " + pDamage;
	}
	
	
}
