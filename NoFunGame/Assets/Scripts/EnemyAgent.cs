using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class EnemyAgent : MonoBehaviour{



    public Vector3 curTarget;
    public NavMeshAgent myAgent;


    //void OnBecameInvisible()
    void Start()
    {
        
        myAgent.speed = 6;
        // Invoke("Hide", 5);
    }

    void OnBecameVisible()
    {
        Hide();
    }

    //void OnTriggerEnter()
    //{
    //    Invoke("ChangeHidingSpot", 5);
    //}

    //    void ChangeTarget()
    //{
    //    curTarget = UnityEngine.Random.Range(0, RecyclableList.Count - 1);
    //}

        void Hide()
    {
        myAgent.destination = curTarget;
    }

    void OnBecameInvisible()
    {
        Invoke("ChangeTarget", 3);
    }

    void ChangeTarget()
    {
        curTarget = GetComponent<RecycleHidingModules>().newLocation;
        Hide();
    }
    //ChangeHidingSpot()
    //{
       
    //}
}
