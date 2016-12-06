using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ResetEndScene : MonoBehaviour
{

    

    void Start()
    {
        Invoke("Loadgame", 114);
    }
    public void Loadgame()
    {
        SceneManager.LoadScene("EndGameScene");
    }

}