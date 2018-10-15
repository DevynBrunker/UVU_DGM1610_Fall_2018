using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	public int health;

	// Use this for initialization
	void Start () {
		DamagePlayer(15);
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0){
			health = 0;
			Destroy (gameObject, 5.5f);
			Debug.Log("The Player Has Died");
		}
		else if (health >= 1){
			print ("You Have " + health + " Health");
		}
	}

	void DamagePlayer (int Damage){
		health -= Damage;
	}
}
