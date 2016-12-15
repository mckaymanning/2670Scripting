using UnityEngine;
using System.Collections;
using System;
//This script takes the point of the mouse and raycasts into the level to determine what location to move the player to, it then moves the player
//to that location. During a discussion on the shortcomings of raycasting position compared to the far cleverer method that Anthony used, Anthony
//declared "You know what, it's fine, I don't care if you use it for the player movement." If memory serves correctly I believe he then went on to
//declare that I, McKay Manning would be receiving an A in his class despite any shortcomings my final project may have.

public class MoveToMouse : MonoBehaviour {


    
    NavMeshAgent myAgent;
    public bool empowered;

    //Establishing the navemeshagent for the player and listening for the playerpowerup bool SendThisBool.
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        PlayerPowerUp.SendThisBool = SendThisBooHandler;
    }

    //Setting this script's bool empowered to the bool of playerpowerup
    private void SendThisBooHandler(bool obj)
    {
        empowered = obj;
    }
    //Function stating if the bool empowered is true than the player's speed should double to 20, otherwise it should be a base of 10.
    void SpeedBoost()
    {
        if (empowered == true)
            GetComponent<NavMeshAgent>().speed = 20;
        else
        {
            GetComponent<NavMeshAgent>().speed = 10;
        }
    }

    //This is my original use of Update and is used to find the location of the mouseclick and moving the player to the click position.
    void Update()
    {
        //This if statement is looking for a mouseclick but specifically asks for the button 1 which should be assigned to the right mouse button.
        if (Input.GetMouseButton(1))
        {
            RaycastHit hit;
        //This takes the raycast from the mouse's click and sets it as the player's navmeshagent's destination.
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                myAgent.destination = hit.point;
            
        }
    }
}
