using UnityEngine;
using System.Collections;

public class RangedAttack : EnemyAttack {

    public override IEnumerator Attack()
    {
        print("Pew!");
        yield return new WaitForSeconds(3);
        print("Pew!");
        yield return new WaitForSeconds(3);
        print("Pew!");
    }
}
