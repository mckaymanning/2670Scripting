using UnityEngine;
using System.Collections;
//Remember to impliment "using System" for Actions to work on your scripts.
using System;
public class EnemyList : MonoBehaviour {
    //This script sends a list of what enemy or objects will hide in the hiding places 
    //This delegate sends transforms out of this script to whatever script will be listening for it (the control script)
    public static Action<Transform> SendThis;

    void Start()
    {
        //transform assigned as SendThis.
        SendThis(transform);
    }

}
