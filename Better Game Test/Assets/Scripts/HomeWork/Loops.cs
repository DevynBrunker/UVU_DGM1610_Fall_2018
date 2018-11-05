using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	//For Loops On/Off
	public bool A;
	public bool B;
	public bool C;

	//While Loops On/Off
	public bool D;
	public bool E;
	public bool F;

	//Variables
	private int num;
	private int life = 99;
	private int add;
	public int regeneration;

	// Use this for initialization
	void Start () {

		//For Loops
		if(!A){
			for(int i = 1; i <= 10; i++){
				print("num = " + i);
			}
		}
		
		if(!B){
			for(int l = 99; l >= 0; l--){
				print("You have " + l + " lifes left");
				if(l == 0 ){
					print("You have died");
				}
			}
		}

		if(!C){
			for(int n = 1; n <= 50; n = n + 3){
				print(n);
			}
		}

		//While Loops
		if(!D){
			while( add <= 9){
				add = add + 1;
				print(add);
			}
		}

		if(!E){
			while( regeneration <= 100){
				regeneration = regeneration + 10;
				if(regeneration == 100){
					print("You Have Max Health");
				}
			}
		}

		// if(!F){
		// 	while(){

		// 	}
		// }
	}
}