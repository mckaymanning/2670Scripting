using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour {

    private Text timerText;
    public float myCoolTimer = 221;
    private int minutes;
    private int seconds;
    private float secToMins;
    int = doubleDigits = 10;

void Start()
    {
        timerText = GetComponent<Text>();
        seconds = (int) (myCoolTimer % secToMins);
        minutes = (int)(myCoolTimer / secToMins);
        
        
        
    }

    void Update()
    {
        
        myCoolTimer -= Time.deltaTime;
        seconds = (int) (myCoolTimer % secToMins);
        minutes = (int)(myCoolTimer / secToMins);
       checkTime();
       
    }
    
    void checkTime()
    {
        if (seconds >= doubleDigits)
             timerText.text = minutes + ":" + seconds;
          else 
          {
             timerText.text = minutes + ":0" + seconds;
          }
    }


}
