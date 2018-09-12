using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
		//Public Uppercase, Private Lowercase
	public int MoveSpeed;
	public float JumpHeight = 15;

	//Player Ground Variable
		//Transform Effects Position, Rotation, And Scale
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool grounded;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}
	
	void FixedUpdate (){
		grounded = Physics2d.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update () {
		
		//This Code Makes The Character Jump
		if(Input.GetKeyDown (KeyCode.Space)&& grounded){
			Jump();
		}

	
	}

	public void Jump(){
		GetComponent<Rigidbody2d>().velocity = new Vector2(GetComponent<Rigidbody2d>().velocity.x, JumpHeight);
	}
}
