using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {

	enum Inventory {cheese, meat, sword, sheild, map, backpack, bow, arrows};

	// Use this for initialization
	void Start () {

		print(Inventory.cheese);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
