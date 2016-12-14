using UnityEngine;
using System.Collections;

public class SexinessBoost : MonoBehaviour, ILootable, IUnavailable
{

    private bool Sexy;
    private bool PoweredUp;

    void OnTriggerEnter()
    {
        PowerUp();
        NotNow();
        StartCoroutine("PowerUpDuration");
    }
    public void PowerUp()
    {
        Sexy = true;
        print("Your are attractive now!");

    }

    public void NotNow()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator PowerUpDuration()
    {
        yield return new WaitForSeconds(10);
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        Sexy = false;
        print("You are no longer turning any heads.");

    }
}


