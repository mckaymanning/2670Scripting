using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SubtractFromScore : MonoBehaviour
{

    //public int count;
    public Text countText;
    public int lossOfPoints;

    // Use this for initialization
    void Start()
    {
		
        staticVars.yourScore = 0;
        //count = 0;
        SetCountText();
    }

    void OnTriggerEnter()
    {

        staticVars.count = staticVars.count - lossOfPoints;
        SetCountText();
        
    }

    void SetCountText()
    {
        if (staticVars.count < 0)
            staticVars.count = 0;

        countText.text = "Stars: " + staticVars.count.ToString();

    }

    void Update()
    {
        
        staticVars.yourScore = staticVars.count;
    }
}
