using UnityEngine;
using System.Collections;
using System;
public class PlayerPowerUp : MonoBehaviour
{
    public static Action<bool> SendThisBool;
    public bool PoweredUp;

    void OnTriggerEnter()
    {
        PoweredUp = true;
        StartCoroutine("PowerCountDown");
        SendThisBool(PoweredUp);
    }


    IEnumerator PowerCountDown()
    {
        yield return new WaitForSeconds(10);
        PoweredUp = false;
        SendThisBool(PoweredUp);
    }



}

