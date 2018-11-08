using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	public GameObject Player2;

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
		// Player = FindObjectOfType<Rigid2D> ();
	}
	
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Generate Death Particles
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//player.enable = false;
		Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore 
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match Players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//show player
		//player.enabled = true
		Player2.SetActive(true);
		Player.GetComponent<Renderer>().enabled = true;
		//Spawn partical
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}