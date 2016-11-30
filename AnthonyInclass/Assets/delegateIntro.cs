using UnityEngine;
using System;

public class delegateIntro : MonoBehaviour {

    //To use Action instead of delegate you need to be "using System;) Above
    public static Action MyEvent;  
    public static Action<string> EventWithArgs;
    public static Func<string> EventString;

    public static Func<string, string> EventReturnArgs;

	void Start ()
    {
        string data = EventReturnArgs("cats");
        print(data);

        print  (EventString());

        EventWithArgs("Hello World");


        //This line is to check if the delegate is null but still allows the game to run.
        //if (MyEvent != null)
            MyEvent();
	}

}
