using UnityEngine;
using System.Collections;

public class BraveEnemy : Enemy 
{

	public override void Shout()
	{
		print ("Let Me at'em! Let Me At'em!");
	}

	public override void Chase()
	{
		
		myAgent.speed = 12;
		myAgent.destination = myTarget.transform.position;

	}

}
