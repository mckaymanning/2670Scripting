using UnityEngine;
using System.Collections;

public class canvasFades : MonoBehaviour
{


    public GameObject myThingy;

    void Start()
    {
        myThingy.SetActive(false);
        Invoke("fadeIn", 7.75f);
    }

    void fadeIn()
    {
        myThingy.SetActive(true);
    }



}
