using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class EnemyAgent : MonoBehaviour{


    //This is a script no longer being used by the hiding enemy, however it did have the enemy moving instead of transporting to a hiding spot.
    //This script should work but would need a list to be sent to it and then randomize the list so the hiding enemy would change hiding spots everytime
    //the camera turns away from it.
    public Vector3 curTarget;
    public NavMeshAgent myAgent;


    
    void Start()
    {  
        //This is setting the speed of the navmeshagent to 6.
        myAgent.speed = 6;
        // Invoke("Hide", 5);
    }
    //When the object is visible by the game camera it runs the Hide function
    void OnBecameVisible()
    {
        Hide();

    }

    //Sets the navmeshagent's destination to the curtarget
    void Hide()
    {
        myAgent.destination = curTarget;
    }
    //When the object is no longer being looked at by the camera the script waits 3 seconds and then runs the changetarget function
    void OnBecameInvisible()
    {
        Invoke("ChangeTarget", 3);
    }
    // This runs the hide function again.
    void ChangeTarget()
    {
   
        Hide();
    }

}
