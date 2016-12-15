using UnityEngine;
using System.Collections;
using System;
//This script takes the player's emptygameobject powertrigger and uses it to set the bool of PoweredUp to true.
//This script then sends the information of the bool over to the player's movement script "MoveToMouse" to allow for a speed boost powerup.
public class PlayerPowerUp : MonoBehaviour
{
    public static Action<bool> SendThisBool;
    public bool PoweredUp;

    //On entering the trigger the bool is set to true, the coroutine PowerCountDown begins and it sends the bool out in the action.
    void OnTriggerEnter()
    {
        PoweredUp = true;
        StartCoroutine("PowerCountDown");
        SendThisBool(PoweredUp);
    }

    //This coroutine counts to 10 seconds, swithches the bool to false and then resends the bool to the player's movement.
    IEnumerator PowerCountDown()
    {
        yield return new WaitForSeconds(10);
        PoweredUp = false;
        SendThisBool(PoweredUp);
    }



}

