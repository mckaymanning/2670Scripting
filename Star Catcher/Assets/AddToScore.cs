﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AddToScore : MonoBehaviour {

    public int count;
    public Text countText;


	// Use this for initialization
	void Start () {
        staticVars.yourScore = 0;
        count = 0;
        SetCountText();
    }
	
    void OnTriggerEnter()
    {
        count = count + 1;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Stars: " + count.ToString();
    }

    void Update()
    {
        staticVars.yourScore = count;
    }
}