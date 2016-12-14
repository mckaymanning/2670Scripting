using UnityEngine;
using System.Collections;

public class ClearClick : MonoBehaviour {

    private GameObject cube;

    void Start()
    {
        cube = gameObject;
    }

    public virtual void OnMouseDown()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }

    public virtual void OnMouseUp()
    {
        cube.GetComponent<Renderer>().enabled = true;
    }


}
