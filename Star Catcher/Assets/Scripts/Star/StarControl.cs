﻿using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour
{

    public int forceTime = 10;
    public float forceDuration = 0.1f;
    private Rigidbody rigid;
    public float forceRange = 10;
    public float torqueRange = 2;
    private Vector3 forceVector;
    private Vector3 torqueVector;

    private Animator anims;

    void Start()
    {
        anims = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }

    IEnumerator RunRandomForce()
    {

        while (forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = Random.Range(-forceRange, forceRange);
            torqueVector.z = Random.Range(-torqueRange, torqueRange);
            rigid.AddTorque(torqueVector);
            rigid.AddForce(forceVector);
            forceTime--;
        }
    }

    public float endTime = 3;

    public void Deactivate()
    {
        anims.SetBool("Destroy", false);
        gameObject.SetActive(false);
    }

    void OnCollisionEnter()
    {
        anims.SetBool("Destroy", true);
        //canAddForce = false;
        //Destroy(gameObject, endTime);
        //gameObject.SetActive(false);

    }


}