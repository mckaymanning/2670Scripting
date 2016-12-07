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
		Chase ();
	}

	public virtual void Shout()
	{
		print ("I'm gonna get you!");
	}


	public virtual void Chase()
	{
		
		myAgent.destination = myTarget.transform.position;
	}
}
