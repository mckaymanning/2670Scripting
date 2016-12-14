using UnityEngine;
using System.Collections.Generic;
using System;

public class Gallerycontrol : MonoBehaviour
{
    public int SpawnTime;
    public List<Transform> DestList;
    public List<Transform> PeopleList;

    // Use this for initialization
    void Start()
    {
        SpawnTime = UnityEngine.Random.Range(1, 5);
        AssignSelf.SendThis += AddDest;
        EnemyList.SendThis += AddPeople;
        Invoke("MoveStuff", SpawnTime);
    }

    private void AddDest(Transform obj)
    {
        DestList.Add(obj);
    }

    private void AddPeople(Transform obj)
    {
        PeopleList.Add(obj);

    }

    void MoveStuff()
    {
        foreach (Transform i in PeopleList)
        {
            int j = UnityEngine.Random.Range(0, DestList.Count - 1);
            i.position = DestList[j].position;
        }
    }

}
