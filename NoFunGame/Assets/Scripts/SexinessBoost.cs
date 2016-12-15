using UnityEngine;
using System.Collections;
//SexinesssBoost inherits Monobehavior but must interface with the requirements of ILootable and IUnavailable
public class SexinessBoost : MonoBehaviour, ILootable, IUnavailable
{

    private bool Sexy;
    private bool PoweredUp;

    //When the trigger is entered by player PowerUp, NotNow and PowerUpDuration are initiated.
    void OnTriggerEnter()
    {
        PowerUp();
        NotNow();
        StartCoroutine("PowerUpDuration");
    }

    //This function meets the requirement for ILootable
    //Sets the bool of Sexy to true.
    //Prints confirmation message that you have picked up the sexinessboost powerup. 
    public void PowerUp()
    {
        Sexy = true;
        print("Your are attractive now!");

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
    //Sets the sexy bool back to false.
    //prints a confirmation message that your sexy powerup has ended.
    IEnumerator PowerUpDuration()
    {
        yield return new WaitForSeconds(10);
        gameObject.GetComponent<Renderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
        Sexy = false;
        print("You are no longer turning any heads.");

    }
}


