using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	public int num;
	private int life = 99;

	// Use this for initialization
	void Start () {
		for(int i = 1; i <= 10; i++){
			print("num = " + i);
		}
		for(int l = 99; l >= 0; l--){
			print("You have " + l + " lifes left");
			if(l == 0 ){
				print("You have died");
			}
		}
		for(){

		}
		// while(){
			
		// }
		// while(){
			
		// }
		// while(){

		// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
