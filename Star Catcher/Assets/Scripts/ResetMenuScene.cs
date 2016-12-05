using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ResetMenuScene : MonoBehaviour {


    
	void Start ()
    {
        Invoke("Loadgame", 114);
	}
    public void Loadgame()
    {
        SceneManager.LoadScene("OpeningPrototype");
    }

}
