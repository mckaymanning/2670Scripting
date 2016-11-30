using UnityEngine;
using System.Collections;
using System;

public class eventHandlerIntro : MonoBehaviour {


	void Start ()
    {
        delegateIntro.MyEvent += MyEventHandler;
        delegateIntro.EventWithArgs += EventWithArgHandler;
        delegateIntro.EventString += EventStringHandler;
        delegateIntro.EventReturnArgs += EventReturnArgsHandler;

    }

    private string EventReturnArgsHandler(string s)
    {
        return "The animals I hate most are " + s;
    }

    private string EventStringHandler()
    {
        print("Do you like cats?");
        return "I hate Cats!";
    }

    private void EventWithArgHandler(string s)
    {
        print(s);
    }

    private void MyEventHandler()
    {
        print("Ran");
    }
}
