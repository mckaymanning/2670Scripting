using UnityEngine;
using System.Collections;

public class CowardEnemy : Enemy 

{
	public override void Shout()
	{
		//base.Shout ();
		print ("PLEASE DON'T KILL ME! I HAVE DREAMS AND ASPIRATIONS");
	}

	public override void Chase()
	{
		
		myAgent.destination = offScreen.transform.position;

	}
}
