using UnityEngine;
using System.Collections;

public class whileLoops : MonoBehaviour {

    int countingDown = 10;

	// Use this for initialization
	void Start ()
    {

        while (countingDown > 0)
        {
            print("My eyes are closed");
            countingDown --;
        }

	}
}
