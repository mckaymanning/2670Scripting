using UnityEngine;
using System.Collections;
using System;

public class AddToTerrainList : MonoBehaviour {

    public static Action<Transform> SendThis;

	// Use this for initialization
	void Start () {
        SendThis(transform);
	}

    void OnBecameInvisible ()
    {
        SendThis(transform);
    }
	
}
