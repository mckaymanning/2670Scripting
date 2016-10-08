using UnityEngine;
using System.Collections;
using System;

public class AnthonyAddToTerrainList : MonoBehaviour {

    public static Action<Transform> SendThis;

    // Use this for initialization
    void Awake()
    {
        SendThis(transform);
    }

    void OnBecameInvisible()
    {
        SendThis(transform);
    }

}

