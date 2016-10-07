
using UnityEngine;
using System.Collections;

public class DestroyObj : MonoBehaviour
{


    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}