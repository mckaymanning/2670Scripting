using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class addName : MonoBehaviour {


    public Text myText;

    void Start()
    {
        print("Hello " + PlayerPrefs.GetString("PlayerName"));
    }

	// Use this for initialization
	public void nameThis () {
        PlayerPrefs.SetString("PlayerName",myText.text);
        print(PlayerPrefs.GetString("PlayerName"));

	}
	

}
