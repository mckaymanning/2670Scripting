
using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour
{

    public Transform characterArt;
    public bool forward = true;

    void FlipCharacter(KeyCode _keyCXode)
    {
        switch (_keyCXode)
        {
            case KeyCode.RightArrow:
                if (forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = false;
                }            
                break;

            case KeyCode.LeftArrow:
                if (!forward)
                {
                    characterArt.Rotate(0, 180, 0);
                    forward = true;
                }
                break;

        }

        characterArt.Rotate(0, 180, 0);
        //forward = _b;
    }

    void StopScript()
    {
       // UserInputs.UserInput += 
    }

    void Start()
    {
        UserInputs.UserInput += FlipCharacter;
        Endgame.GameOver += StopScript;
    }

}