using UnityEngine;
using System.Collections;

public class EnemyMaster : Entity
{
		//public int moveSpeed = 30;

		private GameObject player;		
		public Rigidbody2D myrdby;
		private bool didDamage;
		


		// Use this for initialization
		void Start ()
		{		
			player = GameObject.FindWithTag("Player");
			myrdby = player.GetComponent<Rigidbody2D>();

		}
	
		// Update is called once per frame
		void Update ()
		{
			if(didDamage)
			{
				StartCoroutine("Knockback");				
			}
		}

		void OnTriggerEnter2D (Collider2D obj)
		{										

				if (obj.tag == "Player") 
				{						
					didDamage = true;
					Player.gotHit(true);					
				}

				if (obj.tag == "bullet") 
				{
					Die ();
				}

		}


	public IEnumerator Knockback()
	{
		//Debug.Log ("Player Entered");
		Player.frozen(true);
		myrdby.AddForce(new Vector2(0, -310));

		yield return new WaitForSeconds(0.24f);
		didDamage = false;
		Player.frozen(false);

	}
}
