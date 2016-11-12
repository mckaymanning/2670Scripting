using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour
{

    public NavMeshAgent myAgent;
    public Transform player;
    public Transform Offscreen;
    public ParticleSystem Smoke;
    public ParticleSystem Trail;
    //public Animator myAnims;

    void Start()
    {
        Trail.Play();
       // myAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
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
        Destroy(gameObject, .5f);
    }
}