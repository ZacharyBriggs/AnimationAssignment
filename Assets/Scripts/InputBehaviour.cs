using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    public float Speed;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
	    Animator animate = GetComponent<Animator>();
        Vector3 direction = Vector3.zero;
	    if (Input.GetKeyDown(KeyCode.LeftShift))
	        Speed *= 2;
	    if (Input.GetKeyUp(KeyCode.LeftShift))
	        Speed /= 2;
        if (Input.GetButton("left"))
        {
            rb2d.AddForce(Vector2.left * Speed);
        }

        if (Input.GetButton("right"))
        {
            rb2d.AddForce(Vector2.right * Speed);
        }

        if (Input.GetButtonDown("Jump"))
        {

        }
	}
}
