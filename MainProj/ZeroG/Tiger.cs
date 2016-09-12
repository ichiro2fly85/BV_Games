using UnityEngine;
using System;
using System.Collections;

public class Tiger : BasePlayer {




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


	public Tiger(){
		NinjaName = "Tiger";
		NinjaDescription = "Tiger is the last member that Razor is able to rescue and is the powerhouse of the team. With gauntlets mimicking the claws of Earth animals, " +
		"Tiger's technique is all about predatory instinct. Although not as fast as Razor, his stealth and ability to camouflage makes hunting enemies incredibly simple. " +
		"When outnumbered by enemy lines, he'll release a sonic roar to not only paralyze machines, but also to strike fear in the hearts of men.";

		ExperiencePoints = 0;
		MaxHealthPoints = 1000;
		AttackPoints = 40;
		DefensePoints = 20;
		WalkSpeed = 10;
	}

	private void storeTigerInfo(){

		Global.CurrentNinja = NinjaName;

	}




}
