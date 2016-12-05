using UnityEngine;
using System.Collections;

public class ClearClick : MonoBehaviour {

    public GameObject cube;


    void OnMouseDown()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }

    void OnMouseUp()
    {
        cube.GetComponent<Renderer>().enabled = true;
    }
}
