using UnityEngine;
using System.Collections;

public class StarSpawnerSpinner : MonoBehaviour
{

    // Use this for initialization
    public float spin = 1;
    private Vector3 tempRot;


    void Update()
    {
        tempRot.y = spin * Time.deltaTime;
        transform.Rotate(tempRot);
    }
}