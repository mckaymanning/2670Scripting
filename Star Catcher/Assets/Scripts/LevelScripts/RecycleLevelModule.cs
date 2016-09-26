using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevelModule : MonoBehaviour
{
    private Vector3 newLocation;

    public List<Recycler> RecyclableList;
    private int i = 0;


    System.Random Rnd = new System.Random();
    private float nextTerrain;

    void Start()
    {
        RecyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        RecyclableList.Add(_r);
    }



    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, RecyclableList.Count - 1);
            newLocation.x = staticVars.nextSectionPosition;
			RecyclableList[i].cube.position = newLocation;
			    staticVars.nextSectionPosition += staticVars.distance;
        if (RecyclableList.Count > 0)
        {
            RecyclableList.RemoveAt(i);
        }
    }

}