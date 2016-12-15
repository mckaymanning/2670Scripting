using UnityEngine;
using System.Collections;

//This is the enemy script which will be a parent class that the other children enemy scripts inherit from.
public class Enemy : MonoBehaviour {
    //Setting up what needs to be inherited for the scripts to run their functions
	public NavMeshAgent myAgent;
	public GameObject myTarget;
	public GameObject offScreen;
    //This is a float to experiment with navmeshagents keeping distances from the player and eachother.
    public float personalSpace;

    //When the player enters the enemy's zone enemies should "shout" something by printing it to the console.
    void OnTriggerEnter()
	{
		Shout ();
	}
    //When the player is staying inside the enemy's zone the enemy should "Watch" (lookat) Chase(set destination) and/or keep distance from player.
	void OnTriggerStay()
	{
        Watching();
		Chase ();
        KeepDistance();
	}
    //When the player clicks on the enemy they should print that they were hit to the console.
    void OnMouseDown()
    {
        print("Ouch! You got me!");
    }
    //This is setting up the watching funtion to be able to be overwritten by the child classes that will inherit from it so they can look at
    //different things.
    public virtual void Watching()
    {
        gameObject.transform.LookAt(myTarget.transform.position);
        
    }
    //This is setting up the keepdistance function to be overridden by the child classes so they can have different distances
    public virtual void KeepDistance()
    {
        myAgent.radius = personalSpace;
    }
    //This is setting up the shout function to be overridden by the child classes so they can have different things they shout at the player.
    public virtual void Shout()
	{
		print ("Enemy: I'm gonna get you!");
	}

    //This is setting up the chase function to be overridden by the child classes so they can be set up to chase different things.
    public virtual void Chase()
	{
       	myAgent.destination = myTarget.transform.position;
	}
}
