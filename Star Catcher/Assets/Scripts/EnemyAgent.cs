using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour
{

    public NavMeshAgent myAgent;
    public Transform player;
    public Transform cube;
    public ParticleSystem Smoke;
    public ParticleSystem Trail;
    public bool stolen = false;
    public bool bored = false;
    //public Animator myAnims;


    
    public Vector3 tempPos;
    public Transform wolf;


    public bool canFlipWolf = true;

   void Update ()
    {
        FlipOrNot();
    }

    void OnWillRenderObject()
    {

        Trail.Play();
        
        StayOrGo();
        StartCoroutine(GotBored());
        
        //Chase();
        //Destroy(transform.parent.gameObject, 10);
       // myAgent = GetComponent<NavMeshAgent>();
    }

    void FlipOrNot()
    {
        if (stolen == true || bored == true)
            TurnWolf();
        else
            WolfFlipper();
    }


    void StayOrGo ()
    {
        if (stolen == true || bored == true)
        {
            Runaway();
            
        }
        else
            Chase();
       

    }

    IEnumerator GotBored()
    {
        yield return new WaitForSeconds(8);
        bored = true;
        StayOrGo();
        yield return new WaitForSeconds(10);
        Destroy(transform.parent.gameObject);
    }
    
    void Chase()
    {

        myAgent.destination = player.position;
    }


    void Runaway()
    {
        myAgent.destination = cube.position;
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
        stolen = true;
        StayOrGo();
        //Destroy(Trail);
        //Smoke.Play();
        Destroy(transform.parent.gameObject, 10);
    }

    void WolfFlipper()
    {
        if (player.transform.position.x < wolf.transform.position.x && canFlipWolf)
        {
            wolf.Rotate(0, -180, 0);
            canFlipWolf = true;
        }
        if (player.transform.position.x > wolf.transform.position.x && !canFlipWolf)
        {
            wolf.Rotate(0, 180, 0);
            canFlipWolf = false;
        }
    }


    void TurnWolf()
    {
        if (cube.transform.position.x < wolf.transform.position.x && canFlipWolf)
        {
            wolf.Rotate(0, -180, 0);
            canFlipWolf = true;
        }
        if (cube.transform.position.x > wolf.transform.position.x && !canFlipWolf)
        {
            wolf.Rotate(0, 180, 0);
            canFlipWolf = false;
        }
    }
}