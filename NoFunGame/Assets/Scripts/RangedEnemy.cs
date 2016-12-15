using UnityEngine;
using System.Collections;
//This script inherits from the Enemy scipt
public class RangedEnemy : Enemy {
    //This function polymorphs over the shout function to let the rangedenemy print a different shout
    public override void Shout()
    {
        print("Ranged Enemy: Pew Pew Pew... gotcha");
    }
    //This function polymorphs the original function to allow the rangedenemy keep a farther distance from player.
    public override void KeepDistance()
    {
        myAgent.radius = 8;
    }
    //This function polymorphs the chase function to move after player at different speeds.
    public override void Chase()
    {

        myAgent.speed = 8;
        myAgent.destination = myTarget.transform.position;

    }
}
