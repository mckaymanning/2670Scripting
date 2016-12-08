using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {


    public Animator myAnimator;
    //private object myBody;


    // Use this for initialization
    void Start () {
        myAnimator = GetComponent<Animator>();
        //myBody = GetComponentInParent<CharacterController>();
        
	}
	
	// Update is called once per frame
	void Update () {

        

        //myAnimator.SetFloat("vSpeed", GetComponentInParent<CharacterController>().velocity.y);


       //if (Input.GetKeyDown(KeyCode.Space))
       //    myAnimator.SetBool("isGrounded", false);
       // if (Input.GetKeyUp(KeyCode.Space))
       //    myAnimator.SetBool("isGrounded", false);

		myAnimator.SetBool("isRunning", false);

        if (Input.GetKey(KeyCode.RightArrow))
            myAnimator.SetBool("isRunning", true);
        //if (Input.GetKeyUp(KeyCode.RightArrow))
            //.SetBool("isRunning", false);

        if (Input.GetKey(KeyCode.LeftArrow))
            myAnimator.SetBool("isRunning", true);
        //if (Input.GetKeyUp(KeyCode.LeftArrow))
            //myAnimator.SetBool("isRunning", false);

    }
}
