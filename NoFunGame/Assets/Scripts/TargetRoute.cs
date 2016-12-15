using UnityEngine;
using System.Collections;
//This script sets different point on the navmesh that the navmeshagent will move towards.
public class TargetRoute : MonoBehaviour
{


    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;
        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }

   //On December 14, 2016 Anthony Romrell declared in class, in front of multiple witnesses "OKAY FINE! I will allow you to use two different
   //instances of Update in your projects." This (for the lack of any better solution) is my second use of update outside of the MoveToMouse script.
   void Update()
    {
        if (agent.remainingDistance < 0.5f)
            GotoNextPoint();

        // Choose the next destination point when the agent gets
        // close to the current one.

    }



}

