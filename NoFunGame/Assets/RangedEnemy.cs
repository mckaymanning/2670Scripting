using UnityEngine;
using System.Collections;

public class RangedEnemy : Enemy {

    public override void Shout()
    {
        print("Ranged Enemy: Pew Pew Pew... gotcha");
    }

    public override void Chase()
    {

        myAgent.speed = 8;
        myAgent.radius = 8;
        myAgent.destination = myTarget.transform.position;

    }
}
