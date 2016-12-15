//using UnityEngine;
//using System.Collections.Generic;
//using System;

////This script is not being used now but was for assigning targets to the shooting range.

//public class Gallerycontrol : MonoBehaviour
//{
//    public int SpawnTime;
//    public List<Transform> LocList;
//    public List<Transform> TargetList;

//    // Use this for initialization
//    void Start()
//    {
//        SpawnTime = UnityEngine.Random.Range(1, 5);
//        AssignSelf.SendThis += AddLoc;
//        EnemyList.SendThis += AddTarget;
//        Invoke("MoveStuff", SpawnTime);
//    }

//    private void AddDest(Transform obj)
//    {
//        LocList.Add(obj);
//    }

//    private void AddPeople(Transform obj)
//    {
//        TargetList.Add(obj);

//    }

//    void MoveStuff()
//    {
//        foreach (Transform i in TargetList)
//        {
//            int j = UnityEngine.Random.Range(0, LocList.Count - 1);
//            i.position = LocList[j].position;
//        }
//    }

//}
