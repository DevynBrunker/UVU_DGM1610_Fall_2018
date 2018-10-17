using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	//Move Variables
	public float MoveSpeed;
	public bool MoveRight;

	//Wall Check
	public Transform WallCheck; //Transform is position, ortation, and scale
	public float WallCheckRadius;
	public LayerMask WhatIsWall; //LayerMask is items per layer (like an onion)
	private bool HittingWall;

	//Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;

	// Use this for initialization
	void Update () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);
		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

		if (HittingWall || !NotAtEdge){ // || is or && is and
			MoveRight = !MoveRight; //!Right makes it go left
		}
		if (MoveRight){
			transform.localScale = new Vector3(-7f, 7f, 1f); //flips the sprite
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else{
			transform.localScale = new Vector3 (7f, 7f, 1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
