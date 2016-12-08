using UnityEngine;
using System.Collections;

public class ClearClick : MonoBehaviour {

    private GameObject cube;

    void Start()
    {
        cube = gameObject;
    }

    void OnMouseDown()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }

    void OnMouseUp()
    {
        cube.GetComponent<Renderer>().enabled = true;
    }
}
