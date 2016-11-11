﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SubtractFromScore : MonoBehaviour
{

    public int count;
    public Text countText;
    public int lossOfPoints;

    // Use this for initialization
    void Start()
    {
        staticVars.yourScore = 0;
        count = 0;
        SetCountText();
    }

    void OnTriggerEnter()
    {
        count = count - lossOfPoints;
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
