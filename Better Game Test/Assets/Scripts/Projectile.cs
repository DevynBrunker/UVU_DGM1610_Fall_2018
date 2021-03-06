﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;

	public GameObject PC;
	public GameObject EnemyDeath;
	public GameObject ProjectileParticle;

	public int PointsForKill;
	public int TimeOut;

	

	// Use this for initialization
	void Start () {
		PC = GameObject.Find("Will");

		EnemyDeath = Resources.Load("Prefab/DeathPartical") as GameObject;
		ProjectileParticle = Resources.Load("Prefab/RespawnPartical") as GameObject;

		if(PC.transform.localScale.x < 0){
			Speed = -Speed;
		}

		Destroy(gameObject, TimeOut);

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);

			other.GetComponent<RandomDrop>().Loot();
		}
		
		Destroy (gameObject);
	}

	// void OnCollisionEnter2D(Collision2D other){
	// 	Instantiate(ProjectileParticle, transform.position, transform.rotation);
	// 	Destroy (gameObject);
	// }
}