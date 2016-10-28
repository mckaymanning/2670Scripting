using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Text scoreText;
    public int score;

    public void AddScore(int newScoreValue)
    {

        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;

    }
}