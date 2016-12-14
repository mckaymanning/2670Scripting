using UnityEngine;
using System.Collections;

public class ButtonPush : MonoBehaviour
{

    public int whichButton = 0;
    private bool buttonIsPushed = false;

    void OnTriggerEnter()
    {
        Button();
    }


    void Button()
    {

        whichButton = Random.Range(1, 4);

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