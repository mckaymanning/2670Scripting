using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleHidingModules : MonoBehaviour
{
    public Vector3 newLocation;

    public List<SendToRecycler> RecyclableList;
    private int i = 0;
    private Transform nextTarget;

    System.Random Rnd = new System.Random();
    private float nextTerrain;

    void Start()
    {
        
        RecyclableList = new List<SendToRecycler>();
        SendToRecycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(SendToRecycler _r)
    {
        RecyclableList.Add(_r);
    }



    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, RecyclableList.Count - 1);

//        newLocation.x = staticVars.nextSectionPosition;
        RecyclableList[i].cube.position = newLocation;
//        staticVars.nextSectionPosition += staticVars.distance;
        if (RecyclableList.Count > 0)
        {
            RecyclableList.RemoveAt(i);
        }
    }

}