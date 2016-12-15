using UnityEngine;
using System.Collections;
//This script is no longer being used but assigns rotation through eulerAngles to the Horizontal and Vertical inputs to change which direction
//the camera is facing.
public class MouseLook : MonoBehaviour
{
    //Setting up speed that the camera would turn at
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    //Naming floats yaw and pitch to distinguish if the camera is moving up/down or left/right
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    //On each frame take the yaw and pitch and add to the change of the frame before it by the speed and the input.
    //void Update()
    //{
    //    yaw += speedH * Input.GetAxis("Horizontal");
    //    pitch -= speedV * Input.GetAxis("Vertical");
    ////transform the objects rotation by setting pitch and yaw to the changes of the  x,y,z axis.
    //    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    //}
}