using UnityEngine;
using System.Collections;

//This script is designed to have the hiding spots turn transparent when clicked. It does this by disabling the object's mesh renderer.
public class ClearClick : MonoBehaviour {

    private GameObject cube;

    void Start()
    {
        //This assigns the object itself to variable cube.
        cube = gameObject;
    }
    //When the mouse clicks down on the gameobject or "cube" the renderer.enabled is switched to false, allowing you to see if the
    //hiding enemy is hiding within the cube.
    public virtual void OnMouseDown()
    {
        cube.GetComponent<Renderer>().enabled = false;
    }
    //When the mouse button unclicks the cube the renderer.enabled is switched to true.
    public virtual void OnMouseUp()
    {
        cube.GetComponent<Renderer>().enabled = true;
    }


}
