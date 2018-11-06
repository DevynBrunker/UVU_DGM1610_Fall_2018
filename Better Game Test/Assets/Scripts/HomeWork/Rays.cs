using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rays : MonoBehaviour {

	public int[] Eggs = new int[12];
	public string[] StarWars;

	public bool A;
	public bool B;
	public bool C;
	public bool D;
	public bool E;

	// Use this for initialization
	void Start () {

		if(!A){
			Eggs[0] = 1;
			Eggs[1]	= 2;
			Eggs[2] = 3;
			Eggs[3]	= 4;
			Eggs[4] = 5;
			Eggs[5]	= 6;
			Eggs[6] = 7;
			Eggs[7]	= 8;
			Eggs[8] = 9;
			Eggs[9]	= 10;
			Eggs[10] = 11;
			Eggs[11] = 12;

			print(Eggs[8]);		
		}

		if(!B){
			StarWars = new string[5];

			StarWars[0] = "Obi Wan Kenobi";
			StarWars[1] = "Yoda";
			StarWars[2] = "Mace Windu";
			StarWars[3] = "Kit Fisto";
			StarWars[4] = "Luke Skywalker";

			foreach(string item in StarWars){
				print("Jedi Master " + item);
			}

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

// 5 arrays
// 5 foreach
// make a loop to do a for each loop