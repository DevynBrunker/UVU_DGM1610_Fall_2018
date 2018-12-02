using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

	private int AmmoToAdd;

	void Start(){
		AmmoToAdd = Random.Range (3, 7);
	}

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
			return;
		
		AmmoManager.AddAmmo (AmmoToAdd);

		Destroy (gameObject);
	}
}