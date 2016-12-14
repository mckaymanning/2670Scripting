using UnityEngine;
using System.Collections;
using System;
public class MoveToMouse : MonoBehaviour {


    
    NavMeshAgent myAgent;
    public bool empowered;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        PlayerPowerUp.SendThisBool = SendThisBooHandler;
    }

    private void SendThisBooHandler(bool obj)
    {
        empowered = obj;
    }

    void SpeedBoost()
    {
        if (empowered == true)
            GetComponent<NavMeshAgent>().speed = 20;
        else
        {
            GetComponent<NavMeshAgent>().speed = 10;
        }
    }


    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                myAgent.destination = hit.point;
            
        }
    }
}
