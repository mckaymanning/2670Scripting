using UnityEngine;
using System.Collections;
//This script inherits from the enemyattack script
public class RangedAttack : EnemyAttack {
    //This is where the ranged attack polymorphs the enemyattack script
    public override IEnumerator Attack()
    {
        //This prints pew to the console through intervals of 3 seconds.
        print("Pew!");
        yield return new WaitForSeconds(3);
        print("Pew!");
        yield return new WaitForSeconds(3);
        print("Pew!");
    }
}
