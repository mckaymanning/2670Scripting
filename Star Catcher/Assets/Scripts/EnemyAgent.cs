using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour
{

    public NavMeshAgent myAgent;
    public Transform myTarget;
    public Transform player;
    public Transform cube;
    public ParticleSystem Smoke;
    public ParticleSystem Trail;
    //public bool stolen = false;
    //public bool bored = false;
    //public Animator myAnims;



    void Start()
    {
        
        myTarget = player;
        //Chase();
    }

    //void Update()
    //{
    //    Chase();
    //}

    void switchTarget()
    {
        myTarget = cube;
        Destroy(transform.parent.gameObject, 12);
    }

    void OnTriggerEnter()
    {
        switchTarget();
        
    }

    void OnWillRenderObject()
    {
        Chase();
        Trail.Play();
        Invoke("switchTarget", 8);
    }

    void Chase()
    {

        myAgent.destination = myTarget.position;
    }


    //  void OnWillRenderObject()
    //  {

    //      Trail.Play(); 
    //      StayOrGo();
    //Invoke ("switchTarget", 5);

    //StartCoroutine(GotBored());

    //Chase();
    //Destroy(transform.parent.gameObject, 10);
    // myAgent = GetComponent<NavMeshAgent>();
    //}



    //void StayOrGo ()
    //{
    //    if (stolen == true || bored == true)
    //    {
    //        Runaway();

    //    }
    //    else
    //        Chase();


    //}



    //    IENumerator GotBored()
    //    {
    //        yield return new WaitForSeconds(8);
    //        bored = true;
    //        StayOrGo();
    //        yield return new WaitForSeconds(10);
    //        Destroy(transform.parent.gameObject);
    //    }



    //  void Runaway()
    //  {
    //      myAgent.destination = cube.position;
    //Destroy (transform.parent.gameObject, 12);
    //  }


    //if (myAgent.isOnOffMeshLink)
    //{
    //    myAnims.SetBool("jump", true);

    //}

    //if (!myAgent.isOnOffMeshLink)
    //{
    //    myAnims.SetBool("jump", false);

    //}


    //void OnTriggerEnter()
    //{

    //    stolen = true;
    //    StayOrGo();
    //    //Destroy(Trail);
    //    //Smoke.Play();
    //    Destroy(transform.parent.gameObject, 10);
    //}



}