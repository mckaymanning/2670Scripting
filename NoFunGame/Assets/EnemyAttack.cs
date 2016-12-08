using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {


    void OnTriggerEnter()
    {
        StartCoroutine(Attack());
    }

    public virtual IEnumerator Attack()
    {
        print("Attack!");
        yield return new WaitForSeconds(5);
        print("Attack!");
        yield return new WaitForSeconds(10);
        print("Heavy Attack!!!");

    }


}
