using UnityEngine;
using System;
using System.Collections;

public class ZeroNinja : BasePlayer {

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

    public ZeroNinja()
    {
        NinjaName = "Zero";
        NinjaDescription = "The main protagonist of the group. When Earth was attacked by the Kazi Kamikaze, Razor was the only civilian that was able to find shelter during their invasion."
                            + "However, three of his friends were captured for public execution for resisting the Kamikaze. Before this could happen, he infiltrated the mothership in hopes of saving them." 
                            + "Specializing in swords and quick/deadly strikes, Razor is the fastest member of the team.";

        ExperiencePoints = 0;
        MaxHealthPoints = 1000;
        AttackPoints = 40;
        DefensePoints = 20;
        WalkSpeed = 10;
    }

	private void storePlayerInfo(){
	}

   
}
