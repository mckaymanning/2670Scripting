using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {


    void OnBecameInvisible()
    {
        Destroy (gameObject);
    }
}
