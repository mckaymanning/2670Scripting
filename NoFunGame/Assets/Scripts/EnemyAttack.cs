using UnityEngine;
using System.Collections;
//This is a parent class that the other enemyattack scripts will inherit from
public class EnemyAttack : MonoBehaviour {

    //When the player enters the trigger area the coroutine Attack is started. 
    void OnTriggerEnter()
    {
        StartCoroutine(Attack());
    }
    //This is the attack coroutine and it is set up to be overrriden by the child classes
    //during the attack coroutine the enemy prints out different shouts to the console.
    public virtual IEnumerator Attack()
    {
        print("Attack!");
        yield return new WaitForSeconds(5);
        print("Attack!");
        yield return new WaitForSeconds(10);
        print("Heavy Attack!!!");

    }


}
