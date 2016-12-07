using UnityEngine;
using System.Collections.Generic;
using System;

public class control : MonoBehaviour {

    public List<Transform> DestList;
    public List<Transform> PeopleList;

	// Use this for initialization
	void Start () {
        AssignSelf.SendThis += AddDest;
        EnemyList.SendThis += AddPeople;
        Invoke("MoveStuff", 3);
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


    // Update is called once per frame
    void Update () {
	
	}
}
