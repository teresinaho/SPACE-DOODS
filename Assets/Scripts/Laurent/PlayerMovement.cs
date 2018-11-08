﻿
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public CharacterController2D controller;
public Animator animator;

public float runSpeed = 40f;

float horizontalMove = 0f;

	
	// Update is called once per frame
	void Update () {
		
horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;  

	}

	void FixedUpdate ()

	{
// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);


		if (Input.GetButtonDown ("swing")) 
		{
	animator.SetBool("Hit", true);
		}
	}
}
