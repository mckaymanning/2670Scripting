using UnityEngine;
using System.Collections;

public class starSpin : MonoBehaviour
{

    public float spin = 1;
    private Vector3 tempRot;


    void Update()
    {
        tempRot.z = spin * Time.deltaTime;
        transform.Rotate(tempRot);
    }
}
