using UnityEngine;
using System;
using System.Collections;

public class Jun : BasePlayer {


	// Use this for initialization
	void Start () 
	{
		myRig = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () 
	{
		Controls();
	}

	//Constructor
	public Jun()
	{
		NinjaName = "Jun";
		NinjaDescription =  "Jun is Razor's younger sister and the first member he rescues. Although lacking in physical power, " +
							"her strengths lie in her intelligence, counter strikes, and ability to strategically set up traps for her enemies. " +
							"Her weapon of choice is the razor ring. Jun's defense is near flawless as her weapon makes close range combat difficult for her enemies.";

		ExperiencePoints = 0;
		MaxHealthPoints = 1000;
		AttackPoints = 40;
		DefensePoints = 20;
		WalkSpeed = 10;
	}




}
