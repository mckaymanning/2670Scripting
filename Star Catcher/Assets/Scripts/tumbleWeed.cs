using UnityEngine;
using System.Collections;

public class tumbleWeed : MonoBehaviour {

    //public float spin = 1;
    public float speed = 1;
    private Vector3 tempPos;
    
    //private Vector3 tempRot;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        tempPos.x = speed * Time.deltaTime;
        //tempRot.z = spin * Time.deltaTime;
        transform.Translate(tempPos);
        //transform.Rotate(tempRot);
        
    }
}
