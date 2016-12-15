using UnityEngine;
using System.Collections.Generic;
using System;
//This is a control script for the hiding enemy section of the game. it contains the lists of places to hide and the enemies hiding. It randomizes the
//hiding spots and moves to hiding enemy to one of the locatiosn from the list.
public class control : MonoBehaviour {

    public List<Transform> DestList;
    public List<Transform> PeopleList;

	// On start the transforms being sent over from the other scripts or assigned to adddest and addpeople.
	void Start () {
        AssignSelf.SendThis += AddDest;
        EnemyList.SendThis += AddPeople;
        // The MoveStuff function will begin in 3 seconds after start.
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
    //The MoveStuff function takes the transforms from peoplelist and randomly assigns it's position to one of the positions of the transforms
    //from the hiding places list.
    void MoveStuff()
    {
        foreach (Transform i in PeopleList)
        {
            int j = UnityEngine.Random.Range(0, DestList.Count - 1);
            i.position = DestList[j].position;
        }
    }

}
