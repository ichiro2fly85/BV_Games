
using UnityEngine;
using System.Collections;

public class Ninja : MonoBehaviour {


	// Variables
	private int points = 0;
	public int speed;
	protected int ninjaHealth = 1000;
	private Animator animator;
	private Rigidbody2D myRig;
	private Vector2 vect;
	private GameObject playerObj;
	public float xMovement;
	public float yMovement;
	private bool isRight;




	void Start () 
	{
		myRig = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
	}

	void Update () 
	{
		Controls();
	}



	//Controls
	public void Controls()
	{

		//animator.SetBool("walkdown", false);
		//Player Controls--------------------------------------->
		xMovement = Input.GetAxis("Horizontal");
		yMovement = Input.GetAxis("Vertical");

		myRig.velocity = new Vector2(0, 0);


		//Move up

		if(yMovement > 0.3)
		{

			myRig.velocity = new Vector2(myRig.velocity.x, speed);
		}

		//Move down						

		if(yMovement < -0.3)
		{

			myRig.velocity = new Vector2(myRig.velocity.x, -speed);
		}

		//Move left

		if(xMovement  < -0.3)
		{	
			myRig.velocity = new Vector2(-speed, myRig.velocity.y);			
		}

		//Move right

		if(xMovement > 0.3)
		{
			myRig.velocity = new Vector2(speed, myRig.velocity.y);
		}





		//-----------------------------------------------End of Controls

		if (isfroze) 
		{
			freezePlayer ();
		}	
		else
		{
			unfreezePlayer();
		}



		if (isHit)
		{
			tookDamage();
			isHit = false;

		}				


	}

	//Handing player freeze------------------------------------->>
	public static bool frozen(bool fr)
	{
		isfroze = fr;
		return isfroze;
	}

	public void freezePlayer()
	{
		isfroze = true;
		speed = 0;
	}

	public void unfreezePlayer()
	{
		speed = 6;
	}
	//Handing player freeze END---------------------------------->>



	//Handling Damage Start------------------------------------->>
	public float currentHealth()
	{
		return ninjaHealth;
	}

	public float addDamage(int x)
	{
		ninjaHealth -= x;
		return ninjaHealth;
	}

	public void tookDamage()
	{
		if (ninjaHealth == 0) 
		{
			//YOU LOSE
			return;
		}
		else
		{
			addDamage(100);
			//Global.addPlayerDamage(currentHealth());
		}
		return;
	}
	//Handling Damage End---------------------------------------->>


	//Handling Point System-------------------------------------->>

	public int currentPoints()
	{
		return points;
	}

	public int addPoints(int x)
	{
		points += x;
		return points;
	}


	//Handling Point System End---------------------------------->>

	public static bool gotHit(bool h)
	{
		isHit = h;
		return isHit;

	}



}
