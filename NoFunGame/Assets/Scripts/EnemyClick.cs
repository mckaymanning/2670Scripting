using UnityEngine;
using System.Collections;

public class EnemyClick : ClearClick
{

    public override void OnMouseDown()
    {
        GetComponent<NavMeshAgent>().enabled = false;
    }

    public override void OnMouseUp()
    {
        StartCoroutine("RebootEnemy");
    }

    IEnumerator RebootEnemy()
    {
        yield return new WaitForSeconds (10);
        GetComponent<NavMeshAgent>().enabled = true;
    }
}
