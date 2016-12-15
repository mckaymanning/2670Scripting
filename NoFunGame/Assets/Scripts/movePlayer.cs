//using UnityEngine;
//using System.Collections;
////This script is no longer being used buy was written to transform the object of the player
//public class movePlayer : MonoBehaviour {


//    //Assigning the character controller and different variables
//    public CharacterController myCC;
//    private Vector3 tempPos;
//    public float speed;
//    public float depthSpeed;
//    //Tried to impliment the mouselook script to this one
//    public float speedH = 2.0f;
//    public float speedV = 2.0f;

//    private float yaw = 0.0f;
//    private float pitch = 0.0f;

//    void Update()
//    {

//        yaw += speedH * Input.GetAxis("Horizontal");
//       // pitch -= speedV * Input.GetAxis("Vertical");

//        myCC.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

//        //tempPos.x = speed * Input.GetAxis("Horizontal");

//       // tempPos.z = depthSpeed * Input.GetAxis("Vertical");
        
        
//        myCC.Move(tempPos * Time.deltaTime);
//    }


//}
