using UnityEngine;
using System.Collections;

public class blinkCamera : MonoBehaviour {

	public Camera playerCam;

	void Update()
	{
		if (Input.GetKey (KeyCode.Space))
		playerCam.enabled = false;
	}

}
