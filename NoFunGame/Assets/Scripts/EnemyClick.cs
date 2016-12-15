using UnityEngine;
using System.Collections;

//This script inherits from the clearclick script
public class EnemyClick : ClearClick
{
    //This overrides the clearclick onmousedown and instead of making the enemy "clear" it stops the enemy's mavmeshagent's progress.
    public override void OnMouseDown()
    {
        GetComponent<NavMeshAgent>().Stop();

    }
    //This overrides the clearclick onmouseup and starts the coroutine rebootenemy.
    public override void OnMouseUp()
    {
        StartCoroutine("RebootEnemy");
    }
    //This coroutine waits for 10 seconds and then lets the enemy's navmeshagent resume towards it's destination.
    IEnumerator RebootEnemy()
    {
        yield return new WaitForSeconds (10);
        GetComponent<NavMeshAgent>().Resume();

    }
}
