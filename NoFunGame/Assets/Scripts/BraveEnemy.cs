using UnityEngine;
using System.Collections;
//This script inherits from the Enemy script. It inherits what to do while OnTriggerEnter and OnTriggerStay.
public class BraveEnemy : Enemy 
{
    //This is where this script polymorphs and changes what consequences come from the OnTriggerEnter and OnTriggerStay commands.

    //This changes what the enemy prints for the brave enemy
	public override void Shout()
	{
		print ("Brave Enemy: Let Me at'em! Let Me At'em!");
	}
    //This changes how the brave enemy chases you compared to the enemy chase.
	public override void Chase()
	{
	//The brave enemy should chase the player faster than the regular enemy.	
		myAgent.speed = 12;
		myAgent.destination = myTarget.transform.position;

	}

}
