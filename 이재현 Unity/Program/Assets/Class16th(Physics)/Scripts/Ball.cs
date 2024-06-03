using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 direction;
    private float speed = 5.0f;
    private Rigidbody rigidBody;
    public GameManager manager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();    
    }

 
    void Update()
    {   if(manager.State==false)
        {
           
            rigidBody.freezeRotation = true;
            rigidBody.useGravity = false;
            rigidBody.Sleep();
            return;
        }
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {   
        if(manager.State==false)
        { 
            return;
        }
        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("OnCollisionEnter");
    //}
    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("OnCollisionStay");
    //}
    //    private void OnCollisionExit(Collision collision)
    //    {
    //        Debug.Log("OnCollisionExit");
    //    }
   }
