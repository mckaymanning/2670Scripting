using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour
{

    public NavMeshAgent myAgent;
    public Transform player;
    
    public ParticleSystem Smoke;
    public ParticleSystem Trail;
    
    
    //public Animator myAnims;

    void OnWillRenderObject()
    {
        Trail.Play();
        Chase();
        Destroy(transform.parent.gameObject, 10);
       // myAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Chase()
    {

        myAgent.destination = player.position;
    }

    //if (myAgent.isOnOffMeshLink)
    //{
    //    myAnims.SetBool("jump", true);

    //}

    //if (!myAgent.isOnOffMeshLink)
    //{
    //    myAnims.SetBool("jump", false);

    //}


    void OnTriggerEnter()
    {
        Destroy(Trail);
        Smoke.Play();
        Destroy(transform.parent.gameObject, .5f);
    }
}