using UnityEngine;
using System.Collections;
//This is my interafae control script. This script sets the parameters for any powerups in the game.
//Ilootable is asking for the function Powerup allowing the player to receive some type of powerup when triggered.
public interface ILootable

{
    //Must have function called PowerUp
    void PowerUp();
}

//Iunavailable is setting up a time that the powerup won't be available for pickup after the player has  triggered the powerup.
public interface IUnavailable
{
    //Must have function called NotNow
    void NotNow();
}