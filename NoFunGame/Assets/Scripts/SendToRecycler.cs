using UnityEngine;
using System.Collections;
using System;
public class SendToRecycler : MonoBehaviour
{

    public static Action<SendToRecycler> SendThis;
    public bool canRecycle;


    void Start()
    {
        if (canRecycle)
            SendThis(this);

    }

    void OnTriggerEnter()
    {
        canRecycle = true;
        Start();
    }
}