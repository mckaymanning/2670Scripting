using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public NavMeshAgent myAgent;
	public GameObject myTarget;
	public GameObject offScreen;
    public float personalSpace;
	void OnTriggerEnter()
	{
		Shout ();
	}

	void OnTriggerStay()
	{
        Watching();
		Chase ();
        KeepDistance();
	}

    public virtual void Watching()
    {
        gameObject.transform.LookAt(myTarget.transform.position);
        
    }

    public virtual void KeepDistance()
    {
        myAgent.radius = personalSpace;
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
