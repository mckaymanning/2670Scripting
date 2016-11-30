using UnityEngine;
using System.Collections;

public class WolfArtFlip : MonoBehaviour
{

    public GameObject player;
    public GameObject cube;
	public GameObject mytarget;
	public Vector3 tempPos;
    public Transform wolf;
    
    
	public bool canFlipWolf = false;

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

	void Start()
	{
		mytarget = player;
	}


	void switchTarget()
	{
		mytarget = cube;
	}


	void OnTriggerEnter()
	{
		switchTarget ();
	}


	void OnWillRenderObject()
	{
		Invoke ("switchTarget", 8);
	}


	void WolfFlipper()
	{
		if (mytarget.transform.position.x < wolf.transform.position.x && canFlipWolf)
		{
			wolf.Rotate(0, -180, 0);
			canFlipWolf = false;
		}
		if (mytarget.transform.position.x > wolf.transform.position.x && !canFlipWolf)
		{
			wolf.Rotate(0, 180, 0);
			canFlipWolf = true;
		}
	}



//    void WolfFlipper()
//    {
//        if (player.transform.position.x < wolf.transform.position.x && canFlipWolf)
//        {
//            wolf.Rotate(0, -180, 0);
//            canFlipWolf = false;
//        }
//        if (player.transform.position.x > wolf.transform.position.x && !canFlipWolf)
//        {
//            wolf.Rotate(0, 180, 0);
//            canFlipWolf = true;
//        }
//    }
//	void OnTriggerEnter()
//	{
//		canFlipWolf = false;
//	}

//	void Falsify()
//	{
//		canFlipWolf = false;
//	}

//	void OnTriggerEnter()
//	{
//		Falsify ();
//	}

//	void OnWillRenderObject()
//	{
//		Invoke ("Falsify", 5);
//	}

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