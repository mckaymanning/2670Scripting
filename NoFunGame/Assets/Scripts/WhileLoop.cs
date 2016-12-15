using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    public int powerDown = 5;


    void OnMouseDown()
    {
        while (powerDown > 0)
        {
            print("Powering Down");
            powerDown--;
        }
    }
}