using UnityEngine;
using System.Collections;

public class StarVelocity : MonoBehaviour {

    public int forceTime = 10;
    public float forceDuration = 0.1f;
    private Rigidbody rigid;
    public float forceRange = 10;
    private Vector3 forceVector;


    void Start()
    {
        
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }

    IEnumerator RunRandomForce()
    {

        while (forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = Random.Range(-forceRange, forceRange);     
            rigid.AddForce(forceVector);
            forceTime--;
        }
    }

    public float endTime = 3;
}

