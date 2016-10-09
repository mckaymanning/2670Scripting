﻿using UnityEngine;
using System.Collections;

public class ArtFlip : MonoBehaviour
{

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCode)
    {
        switch (_keyCode)
        {
            case KeyCode.LeftArrow:
                if (forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = false;
                }
                break;

            case KeyCode.RightArrow:
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                }
                break;
        }
    }

    void StopScript()
    {
        newUserInput.UserInput -= FlipCharacter;
    }
    
    void Start()
    {
        //EndGame.GameOver += StopScript;
        newUserInput.UserInput += FlipCharacter;
    }
}