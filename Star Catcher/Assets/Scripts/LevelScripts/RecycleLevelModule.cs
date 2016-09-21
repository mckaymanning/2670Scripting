using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevelModule : MonoBehaviour
{
    private Vector3 newLocation;

    public List<Recycler> RecyclableList;
    private int i = 0;


    void Start()
    {
        RecyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        RecyclableList.Add(_r);
    }


    // void Start()
    //{
    //     staticVars.nextSectionPosition = 32;
    // }


    void OnTriggerEnter()
    {
			newLocation.x = staticVars.nextSectionPosition;
			RecyclableList[i].cube.position = newLocation;
			staticVars.nextSectionPosition += staticVars.distance;
            if (i < RecyclableList.Count-1)
                i++;
    }

}