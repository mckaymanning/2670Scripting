using UnityEngine;
using System.Collections;

public class RecycleLevelModule : MonoBehaviour
{
    private Vector3 newLocation;
    void Start()
    {
        staticVars.nextSectionPosition = 28;
    }


	void OnTriggerEnter()
    {
			newLocation.x = staticVars.nextSectionPosition;
			transform.position = newLocation;
			staticVars.nextSectionPosition += staticVars.distance;
		 


		
		}

}