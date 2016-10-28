using UnityEngine;
using System.Collections;

public class StarTrailDestroy : MonoBehaviour {

    public GameObject Trail;

    void OnTriggerDestroy()
    {
        Destroy(Trail);
    }
}
