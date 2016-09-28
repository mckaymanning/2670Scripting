using UnityEngine;
using System.Collections;
using System;
public class sendToRecycler : MonoBehaviour {

    public static Action<sendToRecycler> SendThis;
    public bool canRecycle;


	void Start ()
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
