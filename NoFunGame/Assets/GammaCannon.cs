using UnityEngine;
using System.Collections;

public class GammaCannon : MonoBehaviour
{
    int powerLevelNeeded = 10;

    void OnTriggerEnter()
    {
           
        StartCoroutine("Charging");
    }

    IEnumerator Charging()
    {
        yield return new WaitForSeconds(1);
        for (int p = 0; p < powerLevelNeeded;  p++)
        {
            print("Gamma Cannon Charging" + p);
        }
    }
}
