using UnityEngine;
using System.Collections;
//This script sets the targets to disappear for 20 seconds after being clicked.
public class targetClick : MonoBehaviour {

    private int Score;
    private GameObject Sphere;

    //Setting the gameobject to the variable sphere.
    void Start()
    {
        Sphere = gameObject;
    //Setting the score to zero.
        Score = 0;
    }
    //OnMouseDown the targets renderer is disabled making them appear to be gone. Also starts coroutine resettarget.
    void OnMouseDown()
    {
        Sphere.GetComponent<Renderer>().enabled = false;
        StartCoroutine("ResetTarget");
        //prints click confirmation to console
        print("Pop");
    }
    //After 20 seconds the target's renderer is enabled making it to reappear.
    IEnumerator ResetTarget()
    {
        yield return new WaitForSeconds(20);
        Sphere.GetComponent<Renderer>().enabled = true;
    }
}
