using UnityEngine;
using System.Collections;

//This script inherits from the EnemyAttack script. It inherits what to do on OnTriggerEnter and OnTriggerStay
public class BraveAttack : EnemyAttack

{
    //This is where the EnemyAttack script is polymorphed into the BraveAttack script
    //This allows the brave enemy to shout different things when the player comes too close.
    public override IEnumerator Attack()
    {
        print("Smash!");
        yield return new WaitForSeconds(5);
        print("Smash!");
        yield return new WaitForSeconds(10);
        print("Sucker Punch!!!");
    }


}
