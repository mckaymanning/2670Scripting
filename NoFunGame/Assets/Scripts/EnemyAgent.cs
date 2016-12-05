using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyAgent : MonoBehaviour {



    public Transform curTarget;
    public NavMeshAgent myAgent;


    void Start()
    {
        
        Hide();
    }

    //void OnTriggerEnter()
    //{
    //    Invoke("ChangeHidingSpot", 5);
    //}

        void Hide()
    {
        myAgent.destination = curTarget.position;
    }

    //ChangeHidingSpot()
    //{
       
    //}
}
