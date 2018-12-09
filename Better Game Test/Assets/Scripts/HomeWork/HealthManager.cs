using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public static int Health = 3;
	Text HealthText;

	public GameObject Will;

	public Text LoseText;

	Text YouLose;

	void Awak(){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		HealthText = GetComponent<Text>();

		LoseText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(Health <= 0){
			Health = 0;
		}

		if(Health >= 5){
			Health = 5;
		}

		HealthText.text = " " + Health;

		if(Health <= 0){
			print("You Lose");
			LoseText.GetComponent<Text>().enabled = true;
			Will.GetComponent<Move>().enabled = false;
		}
	}

	public static void AddHealth (int HealthToAdd){
		Health += HealthToAdd;
	}
}