﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rays : MonoBehaviour {

	public int[] Eggs = new int[12];
	public string[] StarWars;
	public float[] Num = new float[6];
	public char[] Test;
	public bool[] TF = new bool[4];

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

		if(!C){
			Num[0] = 3.2f;
			Num[1] = 4.1f;
			Num[2] = .7f;
			Num[3] = 8.0f;
			Num[4] = 6.9f;
			Num[5] = 5.5f;

			foreach(float item in Num){
				//doing item + item is making the nums double
				print(item + item);
			}
				
		}

		if(!D){
			//when using arrays with char, you need to stick with 1 letter 
			Test = new char[4];

			Test[0] = 'a';
			Test[1] = 'b';
			Test[2] = 'c';
			Test[3] = 'd';

			foreach(char item in Test){
				print("You Are Now " + item);
			}
		}

		if(!E){
			TF[0] = true;
			TF[1] = false;
			TF[2] = false;
			TF[3] = true;

			//print(Random.Range(item)):
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

// 5 arrays
// 5 foreach