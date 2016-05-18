using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {


	private int bspeed = 10;
	private static int PlayerDirection;


	void Start () 
	{
		run();	
	}



	public void run()
	{

		switch(PlayerDirection)
		{
		case 1:
			//shooting Up
			this.transform.eulerAngles = new Vector3(0, 0, 90);
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, bspeed += 30);
			break;			
		case 2:
			//shooting Left
			this.transform.eulerAngles = new Vector3(0, 0, 180);
			GetComponent<Rigidbody2D>().velocity = new Vector2(bspeed -= 30, 0);
			break;
		case 3:
			//shooting Right
			GetComponent<Rigidbody2D>().velocity = new Vector2(bspeed += 30,0);
			this.transform.eulerAngles = new Vector3(0, 0, 0);
			break;
		case 4:
			//shooting Down
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, bspeed -= 30);
			this.transform.eulerAngles = new Vector3(0, 0, -90);
			break;
		default: 
			this.transform.eulerAngles = new Vector3(0, 0, 90);
			GetComponent<Rigidbody2D>().velocity = new Vector2(0, bspeed += 30);
			break;
		}
	}

	public static int getplayerDirection(int x)
	{
		PlayerDirection = x;
		return PlayerDirection;
	}

	void OnTriggerEnter2D(Collider2D obj)
	{

		if (obj.tag == "wall")
		{
			Destroy (gameObject);
		}
	}
	
	void OnBecameInvisible()
	{
		Destroy (gameObject);
	}

}
