﻿using UnityEngine;
using System.Collections;
using System;

public class newUserInput : MonoBehaviour
{

    public static Action<KeyCode> UserInput;


    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow) && UserInput != null)
        {
            UserInput(KeyCode.RightArrow);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && UserInput != null)
        {
            UserInput(KeyCode.LeftArrow);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && UserInput != null)
        {
            UserInput(KeyCode.UpArrow);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && UserInput != null)
        {
            UserInput(KeyCode.DownArrow);
        }
    }
}