using UnityEngine;
using System.Collections;
using System;

public class moreHandlers : MonoBehaviour {


	void Start ()
    {
        delegateIntro.EventString += ES;
        delegateIntro.MyEvent += ME;
        delegateIntro.EventWithArgs += EA;
        delegateIntro.EventReturnArgs += ERA;
	}

    private string ES()
    {
        return "Dogs are better";
    }

    private void ME()
    {
        print("Cool Beans!");
    }

    private void EA(string obj)
    {
        print("But I love " + obj);
    }

    private string ERA(string arg1)
    {
        return "I love " + arg1 + " too";
    }
}
