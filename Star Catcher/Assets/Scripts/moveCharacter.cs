using UnityEngine;
using System.Collections;

public class moveCharacter : MonoBehaviour {
    
    //This is the character controller component
    public CharacterController myCC;
    //Temp var of datatype vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float depthSpeed = 1;
    public float gravity = 1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    //Sliding vars
    public int slideDuration = 100;
    public float slideTime = 0.01f;

    //Coroutine for sliding character.
    IEnumerator Slide()
    {
        //Set a temp var to the value of slideDuration
        int durationTemp = slideDuration;
        //
        float speedTemp = speed;
        speed += speed;
        //While loop runs "while" the slideDuration is greater than 0
        while (slideDuration > 0)
        {
            //Decrement the slideDuration
            slideDuration--;
            //yeild "holds the coroutine"
            //return "sends" to the coroutine to do an operation while yielding
            //new creates an instance of an object
            //WaitForSeconds is an object that waits for a duration of time
            yield return new WaitForSeconds(slideTime);
            
        }
        speed = speedTemp;

        slideDuration = durationTemp;

    }


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


        //Start Sliding
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());

        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S))
        {
            //StartCoroutine is a function that calls a coroutine. Use the coroutine in the argument
            StartCoroutine(Slide());

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
        tempPos.z = depthSpeed * Input.GetAxis("Vertical");
        myCC.Move(tempPos * Time.deltaTime);
      
        }
 }

