using UnityEngine;
using System.Collections;
//using UnityEngine.UI;
public class StarCollect : MonoBehaviour
{

    public GameObject thisStar;
    //public Text scoreText;
    //public int score;


    void OnTriggerEnter()
    {
        Destroy(thisStar);
    }



    //public void AddScore(int newScoreValue)
    //{

    //    score += newScoreValue;
    //    UpdateScore();
    //}

    //void UpdateScore()
    //{
    //    scoreText.text = "Score: " + score;

    //}
}