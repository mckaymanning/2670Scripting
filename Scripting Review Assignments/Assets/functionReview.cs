using UnityEngine;
using System.Collections;

public class functionReview : MonoBehaviour {

	public int curHealth = 10;

	// Use this for initialization
	void Start () {
	
		PowerUp ();
	
	}

	void PowerUp()
	{
		curHealth++;
	}


	// Update is called once per frame
	void Update () 
	{
		
		print (curHealth);
	}
}
