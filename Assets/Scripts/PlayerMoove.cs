using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMoove : MonoBehaviour
{ 
    public float speed;
    public float Jump;
    public GameObject Self;
    public bool isGrounded = false;

    public int Count = 0;

    public float X;
    public float Y;
    public float Z;

    public Rigidbody _rb;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {

        float X = Input.GetAxisRaw("Horizontal");
        float Z = Input.GetAxisRaw("Vertical");

        
        if( Count > 0)
        {
            Y = Y + Jump + Count;
            Count -= 1;
        }
        else if(Y > 0)
        {
            Y = Y - 1;
        }
        _rb.AddRelativeForce(X * speed, Y, Z * speed);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Count = 5;
        }
    }

    public void Jumping()
    {
        Y = Y + (Jump - Count);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Ground") { 
            isGrounded = true; 
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
