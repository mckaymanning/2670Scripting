using UnityEngine;
using System.Collections;
//This iss another example of ForLoops
public class SpellReload : MonoBehaviour
{
    //numberOfSpells integer is equal to 3
    int numberOfSpells = 3;

    //when entering the trigger wait 5 seconds and the start the SpellRechargeZone function
    void OnTriggerEnter()
    {
        Invoke("SpellRechargeZone", 5);
    }
    //when the int is smaller than the numberofspells increase the integer, print and confrimation line and the amount of spells.
    void SpellRechargeZone()
    {
        for (int i = 0; i < numberOfSpells; i++)
        {
            Print("Spells Now Charged: " + i);
        }
    }
    //when the mouse is clicked start the shootspel function.
    void OnMouseDown()
    {
        ShootSpell();
    }
    //setting a new integer for current spells which is equal to numberofspells. if j integer is greater than zero than deduct spells
    //print a confirmation line and the amount of spells remaining.
    void ShootSpell()
    {
        for (int j = numberOfSpells; j > 0; j--)
        {
            print("Fireball!" + i);
        }
    }
}