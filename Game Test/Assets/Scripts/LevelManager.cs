using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigid2D Player;

	//Particale Effect
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value (resets the gravity)
	private float GravityStore;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Rigid2D> ();
	}
	
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particles
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		//Hide Player
		player.enable = false;
		player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = player.GetComponent<Rigid2D>().gravityScale;
		player.GetComponent<Rigid2D>().gravityScale = 0f;
		player.GetComponent<Rigid2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-pointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
		
	}
}
