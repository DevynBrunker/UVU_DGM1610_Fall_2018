using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pets : MonoBehaviour {

	public string[] Pet;

	// Use this for initialization
	void Start () {
		Pet = new string[6];

		Pet[0] = "Present";
		Pet[1] = "Racie";
		Pet[2] = "Poppy";
		Pet[3] = "Corky";
		Pet[4] = "Mocha";
		Pet[5] = "Miner";

		foreach(string item in Pet){
			print(item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
