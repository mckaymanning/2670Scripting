using UnityEngine;
using System.Collections;

public class targetClick : MonoBehaviour {

    private int Score;
    private GameObject Sphere;


    void Start()
    {
        Sphere = gameObject;

        Score = 0;
    }

    void OnMouseDown()
    {
        Sphere.GetComponent<Renderer>().enabled = false;
        StartCoroutine("ResetTarget");

        print("Pop");
    }

    IEnumerator ResetTarget()
    {
        yield return new WaitForSeconds(20);
        Sphere.GetComponent<Renderer>().enabled = true;
    }
}
