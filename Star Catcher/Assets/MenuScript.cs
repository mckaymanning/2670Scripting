﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {

    public void Loadgame()
    { 
    SceneManager.LoadScene("DepthPrototype");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("SplashPrototype");
    }
}