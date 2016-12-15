using UnityEngine;
using System.Collections;
//This script is an example of a forloop. 
public class GammaCannon : MonoBehaviour
{
    //This is the integer that the cannon will need to charge to.
    int powerLevelNeeded = 10;
    //Entering the trigger begins the coroutine charging.
    void OnTriggerEnter()
    {
           
        StartCoroutine("Charging");
    }
    //This waits for a seconds and then starts a forloop. it begins to add up while the number is less than the number needed.
    //Prints a message saying it is charging plus shows the number the charge is at.
    IEnumerator Charging()
    {
        yield return new WaitForSeconds(1);
        for (int p = 0; p < powerLevelNeeded;  p++)
        {
            print("Gamma Cannon Charging" + p);
        }
    }
}
