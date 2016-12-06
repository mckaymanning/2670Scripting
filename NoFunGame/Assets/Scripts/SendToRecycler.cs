using UnityEngine;
using System.Collections;
using System;
public class SendToRecycler : MonoBehaviour
{

    public static Action<SendToRecycler> RecycleAction;
    public bool canBeRecycled = false;
    public Transform cube;


    void Start()
    {
        cube = this.GetComponent<Transform>();
        if (RecycleAction != null && canBeRecycled)
        {
            RecycleAction(this);
        }
    }

    void OnTriggerEnter()
    {
        canBeRecycled = true;
        Start();
    }

    void OnTriggerExit()
    {
        canBeRecycled = false;
    }

}
