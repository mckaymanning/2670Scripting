using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class recycleLevel : MonoBehaviour {

    public List<sendToRecycler> recycleList;
    private Vector3 movePos;


    void SendThisHandler(sendToRecycler _r)
    {
        recycleList.Add(_r);
       
    }



	// Use this for initialization
	void Start () {
        recycleList = new List<sendToRecycler>();
        sendToRecycler.SendThis += SendThisHandler;
   
	}


    void OnTriggerEnter()
    {
        int i = UnityEngine.Random.Range(0, recycleList.Count - 1);
        movePos.x = statics.nextPosition;
        recycleList[i].transform.position = movePos;
        recycleList.RemoveAt(i);
        statics.nextPosition += statics.distance;
    }

}
