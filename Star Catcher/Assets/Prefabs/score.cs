using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	// Use this for initialization
	void Start () {
        staticVars.highScore = PlayerPrefs.GetInt("Score, 0");
        StartCoroutine(AddToScore());
	}

    IEnumerator AddToScore()
    {
        staticVars.highScore++;
        yield return new WaitForSeconds(1);
        print(staticVars.highScore);
        StartCoroutine(AddToScore());


    }


    void Ondisable()
    {
        PlayerPrefs.SetInt("Score", staticVars.highScore);
        print("Final Score: " + PlayerPrefs.GetInt("Score"));
        print("Game Over");
    }

}
