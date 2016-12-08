using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public NavMeshAgent myAgent;
	public GameObject myTarget;
	public GameObject offScreen;

	void OnTriggerEnter()
	{
		Shout ();
	}

	void OnTriggerStay()
	{
        Watching();
		Chase ();
	}

    public virtual void Watching()
    {
        gameObject.transform.LookAt(myTarget.transform.position);
        
    }

	public virtual void Shout()
	{
		print ("Enemy: I'm gonna get you!");
	}


	public virtual void Chase()
	{
		
		myAgent.destination = myTarget.transform.position;
	}
}
