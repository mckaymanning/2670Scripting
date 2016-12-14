using UnityEngine;
using System.Collections;

public class IntelligenceBoost : MonoBehaviour, ILootable, IUnavailable {

    private float Intelligence = 5;
    private float TempIntel;
    private bool PoweredUp;

    void OnTriggerEnter()
    {
        PowerUp();
        NotNow();
        StartCoroutine ("PowerUpDuration");
    }
    public void PowerUp()
    {
        TempIntel = Intelligence * 2;
        print("Your Intelligence is now: " + TempIntel);

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
        TempIntel = Intelligence;
        print("You Are Dumb Again. Intelligence: " + TempIntel);

    }
}


