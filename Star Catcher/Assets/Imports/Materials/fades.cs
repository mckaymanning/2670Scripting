﻿using UnityEngine;
using System.Collections;

public class fades : MonoBehaviour {

   
    public GameObject logo;
    
    void Start ()
    {
        logo.SetActive(false);
        Invoke("fadeIn", 1);
	}

    void fadeIn()
    {
        logo.SetActive(true);
    }
	


}
