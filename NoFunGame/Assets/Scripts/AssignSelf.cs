using UnityEngine;
using System.Collections;
using System;

// This will assign the transform of the object it is attached to to auto complete in a different script
// These will be the hiding spots for the hiding enemy.

public class AssignSelf : MonoBehaviour
{

    public static Action<Transform> SendThis;

    void Start()
    {
        SendThis(transform);
    }

}
