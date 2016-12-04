using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {

    public void Loadgame()
    { 
    SceneManager.LoadScene(Random.Range(3, 7));
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("SplashPrototype");
    }

    public void QuitTheGame()
    {
        Application.Quit();

    }
}
