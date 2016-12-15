using UnityEngine;
using System.Collections;
//This script is another example of a switch statement.
public class ConversationTest : MonoBehaviour {

    //declaring a bool for sexy.
    public bool Sexy = false;
    //On entering trigger the greet function will start.
    void OnTriggerEnter()
    {
        Greet();
    }

    void Greet()
    {
        //if the bool is true than it will print the first case, if not it will move to the next.
        switch (Sexy)
        {
            case true:
                print("Why hello there sailor!");
                break;
        //If the bool is false it will print the second case; if for whatever reason these don't apply it will move on to the default.
            case false:
                print("You have a great personality");
                break;
         //If the switch statement defaults it will print this final line.
            default:
                print("UNCOMFORTABLE SILENCE.");
                break;
        }
    }
}
