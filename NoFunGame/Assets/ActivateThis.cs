using UnityEngine;
using System.Collections;
using System;
public class ActivateThis : MonoBehaviour {

    public static bool StartTargets;

    void OnTriggerStay()
    {
        StartTargets = true;
    }

    //void OnTriggerExit()
    //{
    //    StartTargets = false;
    //}

}
