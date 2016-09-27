using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour {

    int powerLevelNeeded = 100;


	// Use this for initialization
	void Start () {

      
            
	}
	
	// Update is called once per frame
	void Update () {

        for (int p = 0; p < powerLevelNeeded; p++)
        {
            print("Gamma Cannon Charging" + p);
        }
    }
}
