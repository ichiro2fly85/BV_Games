using UnityEngine;
using System;
using System.Collections;

public class Wing : BasePlayer {


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
	public Wing()
	{
		NinjaName = "Wing";
		NinjaDescription =  "As the third member to be rescued, Wing is the most mobile character of the team. She enjoys alternating between tessen metal fans and " +
							"her titanium parasol for close range, long range, and defensive purposes. Wing's ability to manipulate air current with her chakra often makes her a very difficult " +
							"target to hit. Both her power and defense are average at best, but her evasive maneuvers are unparalleled.";

		ExperiencePoints = 0;
		MaxHealthPoints = 1000;
		AttackPoints = 40;
		DefensePoints = 20;
		WalkSpeed = 10;
	}




}
