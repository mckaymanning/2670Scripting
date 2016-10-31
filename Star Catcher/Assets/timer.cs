using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour {

    private Text timerText;
    public float myCoolTimer = 221;
  

void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        myCoolTimer -= Time.deltaTime;
       
        timerText.text = myCoolTimer.ToString("f0");
       
    }

    void gameOver()
    {
        SceneManager.LoadScene("SplashPrototype");
    }
}
