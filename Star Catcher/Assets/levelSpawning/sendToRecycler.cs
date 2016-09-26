using UnityEngine;
using System.Collections;
using System;
public class sendToRecycler : MonoBehaviour {

    public static Action<sendToRecycler> SendThis;

	void Start ()
    {

        SendThis(this);

	}
}	
