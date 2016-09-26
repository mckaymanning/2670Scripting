using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class recycleLevel : MonoBehaviour {

    private List<sendToRecycler> recycleList;
    private Vector3 movePos;
    void SendThisHandler(sendToRecycler _r)
    {
        recycleList.Add(_r);
        print(recycleList.Count);
    }



	// Use this for initialization
	void Start () {
        recycleList = new List<sendToRecycler>();
        sendToRecycler.SendThis += SendThisHandler;
   
	}


    void OnTriggerEnter()
    {
        movePos.x = statics.nextPosition;
        recycleList[0].transform.position = movePos;
        statics.nextPosition += statics.distance;
    }

}
