using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyAgent : MonoBehaviour {


    public List<SendToRecycler> recycleList;
    public Transform curTarget;
    public NavMeshAgent myAgent;


    void SendThisHandler(SendToRecycler _r)
    {
        recycleList.Add(_r);

    }

    void Start()
    {
        recycleList = new List<SendToRecycler>();
        SendToRecycler.SendThis += SendThisHandler;
        Hide();
    }

    void OnTriggerEnter()
    {
        Invoke("ChangeHidingSpot", 5);
    }

        void Hide()
    {
        myAgent.destination = curTarget.position;
    }

    ChangeHidingSpot()
    {
        curTarget = UnityEngine.Random.Range(0, recycleList.count - 1);
    }
}
