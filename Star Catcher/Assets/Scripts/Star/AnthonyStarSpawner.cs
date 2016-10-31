using UnityEngine;
using System.Collections;
using System;
public class AnthonyStarSpawner : MonoBehaviour {
     
    public static Action <Transform> SendSpawner;

	// Use this for initialization
	void Start () {
        if (SendSpawner != null)
            SendSpawner(transform);
	}
	

}
