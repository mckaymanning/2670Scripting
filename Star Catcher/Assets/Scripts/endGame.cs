
using UnityEngine;
using System.Collections;
using System;

public class Endgame : MonoBehaviour
{

    public static Action GameOver;


    void OnMouseDown()
    {
        GameOver();
    }

}