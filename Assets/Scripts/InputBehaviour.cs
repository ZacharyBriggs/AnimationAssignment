using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEditor;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    public float Speed;

    private bool IsMoving;

    private bool IsRunning;
    private Animator animate;
    // Use this for initialization
    void Start ()
    {
        animate = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
	{
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        Vector3 direction = Vector3.zero;
	    if (Input.GetKeyDown(KeyCode.LeftShift))
	    {
	        Speed *= 2;
	        animate.SetBool("IsRunning",true);
	    }

	    if (Input.GetKeyUp(KeyCode.LeftShift))
	    {
	        Speed /= 2;
	        animate.SetBool("IsRunning", false);
	    }

	    if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * Speed);
            animate.SetBool("IsWalking", true);
            if (this.gameObject.transform.rotation.y == 0)
            {

            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * Speed);
            animate.SetBool("IsWalking", true);
        }
        else
        {
            animate.SetBool("IsWalking", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            animate.SetBool("IsJumping", true);
            rb2d.AddForce(Vector2.up * Speed);
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        animate.SetBool("IsJumping", false);
    }
}
