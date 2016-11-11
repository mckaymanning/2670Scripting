using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour
{

    public NavMeshAgent myAgent;
    public Transform player;
    public Animator myAnims;

    void Start()
    {
       // myAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        myAgent.destination = player.position;
        print(myAgent.isOnNavMesh);
        if (myAgent.isOnOffMeshLink)
        {
            myAnims.SetBool("jump", true);

        }

        if (!myAgent.isOnOffMeshLink)
        {
            myAnims.SetBool("jump", false);

        }
    }
}