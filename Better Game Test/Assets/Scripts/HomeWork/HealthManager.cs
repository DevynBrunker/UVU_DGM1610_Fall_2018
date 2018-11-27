using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int Health;
	Text HealthText;

	public GameObject Will;

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();
		Health = 3;
	}
	
	// Update is called once per frame
	void Update () {
		// if(){
		// 	Health = Health - 1;
		// }

		if(Health <= 0){
			Health = 0;
			print("Game Over");
		}

		if(Health >= 5){
			Health = 5;
		}

		HealthText.text = " " + Health;
	}

	public static void AddHealth (int HealthToAdd){
		Health += HealthToAdd;
	}
}