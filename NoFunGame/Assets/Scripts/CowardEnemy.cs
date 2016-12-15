using UnityEngine;
using System.Collections;
//This script inherits from the Enemy scripts. It inherits what to do during OnTriggerEnter and OnTriggerStay.
public class CowardEnemy : Enemy 

{
    //This is where the cowardenemy scripts polymorphs what to do during the shout function
	public override void Shout()
	{
		//base.Shout ();
		print ("Coward Enemy: PLEASE DON'T KILL ME! I HAVE DREAMS AND ASPIRATIONS");
	}
    //This is hwere the cowardenemy script polymorphs what to do during the watching function
    //It makes the coward turn away from the player and towards its runaway destination
    public override void Watching()
    {
        gameObject.transform.LookAt(offScreen.transform.position);
    }
    //This is where  the cowardenemy script polymorphs what to do during the chase function
    //This makes the coward enemy run away from the player and towards the runaway destination.
	public override void Chase()
	{
		
		myAgent.destination = offScreen.transform.position;

	}
}
