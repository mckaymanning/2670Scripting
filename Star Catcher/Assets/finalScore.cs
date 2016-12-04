using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class finalScore : MonoBehaviour {

    public Text thisText;
    
    // Use this for initialization


    void Start()
    {

       thisText.text = "Score: " + staticVars.yourScore.ToString();
    }
}
