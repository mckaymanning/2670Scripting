using UnityEngine;
using System.Collections;

public class canvasFades : MonoBehaviour
{


    public GameObject myThingy;

    void Start()
    {
        myThingy.SetActive(false);
        Invoke("fadeIn", 8);
    }

    void fadeIn()
    {
        myThingy.SetActive(true);
    }



}
