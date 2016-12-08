using UnityEngine;
using System.Collections;

public class BraveAttack : EnemyAttack

{
    public override IEnumerator Attack()
    {
        print("Smash!");
        yield return new WaitForSeconds(5);
        print("Smash!");
        yield return new WaitForSeconds(10);
        print("Sucker Punch!!!");
    }


}
