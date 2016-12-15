using UnityEngine;
using System.Collections;
//This is another example of a while loop.
public class whileHiding : MonoBehaviour

   
{
    
    public bool isClicked;
    //When the object is clicked it will set the isClicked bool to true.
    void OnMouseDown()
    {
        isClicked = true;
        //While isClicked is true it will print the confirmation line of being found.
        while (isClicked == true)
        {
            print("You Found Me!");
        }
    }
}

