using UnityEngine;
using System.Collections;

public class starfall : MonoBehaviour {

    private Vector3 tempPos;
    public float gravity = -1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        tempPos.z = gravity * Time.deltaTime;
        transform.Translate(tempPos);
	}
}
