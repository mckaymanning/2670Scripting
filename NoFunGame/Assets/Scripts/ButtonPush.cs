using UnityEngine;
using System.Collections;
//This script is an example of an switch statement.
public class ButtonPush : MonoBehaviour
{

    public int whichButton = 0;
    private bool buttonIsPushed = false;

    //When player enters collider the function Button is started.
    void OnTriggerEnter()
    {
        Button();
    }

    //Button function runs a switch statement that changes what is printed to the console.
    void Button()
    {
        //Setting up a random range of what should be printed whenever the Button function is ran.
        whichButton = Random.Range(1, 4);
        //Swithch statement with three different cases and a default.
        switch (whichButton)
        {
            case 1:
                print("The Improbability Drive Initiated: A");
                break;
            case 2:
                print("The Improbability Drive Initiated: 88");
                break;
            case 3:
                print("The Improbability Drive Initiated: Cerulean");
                break;
            default:
                print("The Improbability Drive Initiated: Marigold");
                break;
        }
    }
}