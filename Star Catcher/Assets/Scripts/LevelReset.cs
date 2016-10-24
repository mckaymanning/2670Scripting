using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelReset : MonoBehaviour
{


    void Start()
    {
        staticVars.nextSectionPosition = staticVars.startPosition;

    }

    void OnTriggerEnter()
    {
        SceneManager.LoadScene("DepthPrototype");
    }
}
