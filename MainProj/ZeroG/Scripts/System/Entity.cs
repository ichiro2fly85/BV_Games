using UnityEngine;
using System.Collections;


public class Entity : MonoBehaviour 
{
	public virtual void Die()
	{
		Destroy(this.gameObject);
	}
	
	public virtual void DieToEnvironment()
	{
		Destroy(this.gameObject);
	}
	
	
	
	
	
	
}


