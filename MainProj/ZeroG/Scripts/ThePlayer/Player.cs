using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	// Variables
	private int points = 0;
	public int speed;
	private float dmgprcent = 0.0f;
	private int currentDir;
	private Animator animator;
	private Rigidbody2D myRig;
	private Vector2 vect;
	private Vector2 vect2;
	private GameObject playerobj;
	public GameObject bullet;
	private static bool isHit;
	private static bool isfroze;
	public float xMovement;
	public float yMovement;
	private bool isRight;



	
	void Start () 
	{
		myRig = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
		animator.SetInteger ("state", 1);
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
		if (Input.GetKey(KeyCode.W))
		{
			animator.SetInteger ("blah", 1);
		}
		else
		{
			animator.SetInteger ("blah", 0);
		}

		if(yMovement > 0)
		{faceUp();}
		if(yMovement > 0.3)
		{

			myRig.velocity = new Vector2(myRig.velocity.x, speed);
		}

		//Move down
		if (Input.GetButton("back"))
		{
			animator.SetInteger ("state", 2);
		}
		else
		{
			animator.SetInteger ("state", 0);
		}


		if (yMovement < 0) 
		{				
			faceDown ();
		}					
				
		if(yMovement < -0.3)
		{

			myRig.velocity = new Vector2(myRig.velocity.x, -speed);
		}

		//Move left

		if (Input.GetButton("left"))
		{
			animator.SetInteger ("state", 3);
		}

		if(xMovement < 0)
		{faceLeft();}
		if(xMovement  < -0.3)
		{	
			myRig.velocity = new Vector2(-speed, myRig.velocity.y);			
		}

		//Move right
		if (Input.GetButton("right"))
		{
			animator.SetInteger ("state", 4);
		}

		if(xMovement > 0)
		{faceRight();}
		if(xMovement > 0.3)
		{
			myRig.velocity = new Vector2(speed, myRig.velocity.y);
		}



		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if(isfroze)
			{
				return;
			}
			else
			{
				if(isRight)
				{
					animator.SetTrigger("bomb");
				}
				else
				{
					animator.SetTrigger("bomb2");
				}
				Instantiate(bullet, transform.position, Quaternion.identity);
			}
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
			
		bulletScript.getplayerDirection(currentDir);
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
	public float currentDamage()
	{
		return dmgprcent;
	}

	public float addDamage(float x)
	{
		dmgprcent += x;
		return dmgprcent;
	}

	public void tookDamage()
	{
		if (dmgprcent == 100) 
		{
			//YOU LOSE
			return;
		}
		else
		{
			addDamage(10.0f);
			Damage.addglobalDamage(currentDamage());
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

	private void faceUp()
	{

		currentDir = 1;

	}

	private void faceLeft()
	{
		//Animation
		isRight = false;
		currentDir = 2;
	}

	private void faceRight()
	{
		//Animation
		isRight = true;
		currentDir = 3;
	}

	private void faceDown()
	{
		//Animation
		currentDir = 4;

	}






}
