using UnityEngine;
using System.Collections;
using System;

public class gameControl : MonoBehaviour {

    public static Action StartGame;
    public static Action EndGame;



    public void StartGameCall()
    {
        print("started game");
        if (StartGame != null)
            StartGame();
    }


}
