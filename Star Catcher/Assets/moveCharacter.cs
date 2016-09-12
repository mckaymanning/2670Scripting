using UnityEngine;
using System.Collections;

public class moveCharacter : MonoBehaviour {

    //This is the character controller component
    public CharacterController myCC;
    //Temp var of datatype vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;

	// Update is called once per frame
	void Update () {
        //Waiting for input and comparing jumpcount
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax-1)
        {
            //incrementing the jumpcount by one
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
        //Test if character controller is grounded
        if (myCC.isGrounded)
        {
            //Reset the jumpcount if grounded
            jumpCount = 0;
        }
        //Adding the gravity var to the y position of the tempPos var
        tempPos.y -= gravity;
        //Adding the speed var to the tempPos var x value with Horizontal input.
        tempPos.x = speed * Input.GetAxis("Horizontal");
        //Moves the character controller at an even pace
        myCC.Move(tempPos * Time.deltaTime);
      
        }
 }

