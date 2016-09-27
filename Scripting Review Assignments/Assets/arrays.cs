using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour
{

    public GameObject[] inventory;

    void Start()
    {
        print("PRESS i FOR INVENTORY");
    }


	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.I))
            InventoryScreen();
	}


    void InventoryScreen()
    {

        inventory = GameObject.FindGameObjectsWithTag("Inventory");

        for(int i = 0; i < inventory.Length; i++)
        {
            print("Inventory Slot"+i+" Contains"+inventory[i].name);
        }
    }
}
