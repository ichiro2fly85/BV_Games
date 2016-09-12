using UnityEngine;
using System.Collections;

public class BattleSystem : MonoBehaviour {


	public enum BattleMode
	{
		INITIALIZE,
		STATUSEFFECT,
		PLAYERTURN,
		ANIMATION,
		ENEMYTURN,
		UPDATE,
		LOSE,
		WIN

	}

	private BattleMode currentMode;


	void Awake()
	{
		currentMode = BattleMode.INITIALIZE;
	}

	/*
	 * If an enemy strikes you and initiates battle one of the following will happens to the character that was hit:
	   First strike for enemies
	   Stun
 	   Dizzy
  	   Poison
	   Disabled
	   Immobile
		If an enemy hits you they always go first in combination with whatever status effect they have.*/

	void Update()
	{	

		switch (currentMode) 
		{
		case (BattleMode.INITIALIZE):
			//Loads player and enemy into new scene then switches to STATUSEFFECT  
			battleStart();
			break;
		case (BattleMode.STATUSEFFECT):
			//Check to see if enemy struck first then checks if a status effect will be set on a player then moves to ENEMYTURN.
			//Check to see if player struck first then checks if a status effect will be set on a player then moves to ENEMYTURN.
			applyStatus();
		case (BattleMode.PLAYERTURN):
			//Starts player turn and saves player choice then switches to UPDATE
			break;
		case (BattleMode.ANIMATION):
			//Receives player choice and gathers enemy attack, finds the corresponding animation for it, checks to see if both have used a turn, logs who attacked last, then switches to UPDATE
			break;
		case (BattleMode.ENEMYTURN):
			//Starts enemy turn and selects attack based on enemy ai then switches to ANIMATION
			break;
		case (BattleMode.UPDATE):
			/*Evaluates player and enemy health, if player health is 0 switch to LOSE, if enemy health is 0 switch to WIN, 
			 * if both are not 0 switch to PLAYERTURN if enemy attacted last and ENEMYTURN if player attacked last*/
			break;
		case (BattleMode.LOSE):
			//Sends message to global that player is dead, end battle mode
			break;
		case (BattleMode.WIN):
			//Sends message to global that player won, end battle mode
			break;
		}
	}

	/*
		If enemy strikes you then battle starts with enemy having first turn choice and with player having status effect of the enemy that hit them, 
		but only if the enemy comes with a particular status effect. **how does player remove status**
	*/


	public void battleStart()
	{
		//Application.LoadLevel
		  currentMode = BattleMode.STATUSEFFECT;
	}

	public void applyStatus()
	{
		if (firstStrike == "true" && setStatus == "true") {
			//apply status to player
			currentMode = BattleMode.ENEMYTURN;

		} else if (firstStrike == "true") {
			
			currentMode = BattleMode.ENEMYTURN;
			
		} else if(firstStrike == "false" && setStatus == "true") {
			//apply status to enemy
			currentMode = BattleMode.PLAYERTURN;

		} else if (firstStrike == "false") {

			currentMode = BattleMode.PLAYERTURN;

	}

	public void enemyTurn()
	{
		
	}

	public void playerTurn()
	{

	}





}


