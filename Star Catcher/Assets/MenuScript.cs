using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour {

    public AudioSource MenuSounds;
    public AudioClip ButtonClick;
    public float volLowRange = .5f;
    public float volHighRange = 1.0f;


    public void Loadgame()
    { 
    SceneManager.LoadScene(Random.Range(3, 7));
    }



    public void LoadMainMenu()
    {
        SceneManager.LoadScene("SplashPrototype");
    }
    public void MainMenu()
    {
        Invoke("LoadMainMenu", 1);
    }



    public void LoadQuitTheGame()
    {
        Application.Quit();
    }

    public void QuitTheGame()
    {
        Invoke("LoadQuitTheGame", 1);
    }



    public void ClickSound()
    {
        float vol = Random.Range(volLowRange, volHighRange);
        MenuSounds.PlayOneShot(ButtonClick, vol);
    }
}
