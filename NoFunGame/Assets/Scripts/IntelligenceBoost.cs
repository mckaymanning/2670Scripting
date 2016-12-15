using UnityEngine;
using System.Collections;
//IntelligenceBoost inherits Monobehavior but must interface with the requirements of ILootable and IUnavailable
public class IntelligenceBoost : MonoBehaviour, ILootable, IUnavailable {

    public static float Intelligence = 5;
    public float TempIntel;
    private bool PoweredUp;
    //When the trigger is entered by player PowerUp, NotNow and PowerUpDuration are initiated.
    void OnTriggerEnter()
    {
        PowerUp();
        NotNow();
        StartCoroutine ("PowerUpDuration");
    }

    //This function meets the requirement for ILootable
    //Takes intelligence int and multiplies it by 2
    //Prints confirmation message that your intelligence has increased.
    public void PowerUp()
    {
      
        TempIntel = Intelligence * 2;
        print("Your Intelligence is now: " + TempIntel);

    }

    //This function meets the requirements for IUnavailable
    //This sets the gameobjects boxcollider and renderer to false. This makes the powerup appear to have disappeared and is uninteractable.
    public void NotNow()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    //This coroutine waits for 10 seconds then sets the powerup's renderer and boxcollider to true again so the player can both see and interact
    //with the powerup again.
    //Sets the intelligence back to the original intelligence level that was stored into the tempIntel variable.
    //prints a confirmation message that your intelligence powerup has ended.
     IEnumerator PowerUpDuration()
    {
        yield return new WaitForSeconds(10);
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        TempIntel = Intelligence;
        print("You Are Dumb Again. Intelligence: " + TempIntel);

    }
}


