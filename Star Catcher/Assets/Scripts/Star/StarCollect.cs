using UnityEngine;
using System.Collections;

public class StarCollect : MonoBehaviour {

	public GameObject thisStar;


	void OnTriggerEnter()
	{
		Destroy(thisStar);
	}
}
