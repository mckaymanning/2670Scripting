using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {



    public CharacterController myCC;
    private Vector3 tempPos;
    public float speed;
    public float depthSpeed;


    void Update()
    {


        tempPos.x = speed * Input.GetAxis("Horizontal");

        tempPos.z = depthSpeed * Input.GetAxis("Vertical");

        myCC.Move(tempPos * Time.deltaTime);
    }
}
