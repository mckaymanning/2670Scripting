﻿using UnityEngine;
using System.Collections;

public class moveRecycleTrigger : MonoBehaviour {

    private Vector3 movePos;
    public float speed = 1;

	// Update is called once per frame
	void Update () {

        movePos.x = speed*Time.deltaTime;
        transform.Translate(movePos);

	}
}
