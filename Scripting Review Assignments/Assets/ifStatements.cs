using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {

    private bool buttonIsPushed = false;
    public int whichButton = 0;

    // Use this for initialization
    void Update() {

        if (Input.GetKeyDown(KeyCode.Space))
            ButtonPush();


    }

    // Update is called once per frame
    void ButtonPush() {

        whichButton = Random.Range(1, 4);

        switch (whichButton)
        {                                    
        case 1:
            print("The Red Button Was Pushed");
            break;
        case 2:
            print("The Blue Button Was Pushed");
            break;
        case 3:
            print("The Green Button Was Pushed");
            break;
        default:
            print("No Button Was Pushed");
            break;


        }
    }
}