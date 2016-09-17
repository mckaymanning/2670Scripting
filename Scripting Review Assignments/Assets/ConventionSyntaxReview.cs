using UnityEngine;
using System.Collections;

public class ConventionSyntaxReview : MonoBehaviour {

	public bool buttonPushed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//I used the assigned jump button in the input manager which is currently assigned to the space bar.
		if (Input.GetButtonDown ("Jump")) {
			print ("THE BUTTON HAS BEEN PUSHED!");
			buttonPushed = true;
		}
		//This is an example of a single line comment that is ignored by everything but me.

		/*This is an example of a multiline comment
		 * that can be used incase you have a lot of different information
		 * that you want written down to help you or others understand what is
		 * going on here.
		 * 
		 * It is also useful for commenting out large blocks of code that you want to keep from running temporarily
		 * while you troubleshoot a problem you're having.
		 * That way you can just uncomment it later and you won't have to rewrite the code.
		 */



	}
}
