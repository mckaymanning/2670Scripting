using UnityEngine;
using System.Collections;

public class WolfArtFlip : MonoBehaviour
{

    public GameObject player;
    public GameObject cube;
    public Vector3 tempPos;
    public Transform wolf;
    
    
    public bool canFlipWolf = true;

    void Update ()
    {
        WolfFlipper();
    }


    //void StayOrGo ()
    //{
    //    if (stolen == true || bored == true)
    //        Runaway();
    //    else
    //        WolfFlipper();
    //} 

    void WolfFlipper()
    {
        if (player.transform.position.x < wolf.transform.position.x && canFlipWolf)
        {
            wolf.Rotate(0, -180, 0);
            canFlipWolf = false;
        }
        if (player.transform.position.x > wolf.transform.position.x && !canFlipWolf)
        {
            wolf.Rotate(0, 180, 0);
            canFlipWolf = true;
        }
    }


    void Runaway()
    {
        if (cube.transform.position.x < wolf.transform.position.x && canFlipWolf)
        {
            wolf.Rotate(0, -180, 0);
            canFlipWolf = false;
        }
        if (cube.transform.position.x > wolf.transform.position.x && !canFlipWolf)
        {
            wolf.Rotate(0, 180, 0);
            canFlipWolf = true;
        }
    }
}