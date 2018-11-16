using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;
	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();
		Ammo = 15;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo < 0){
			Ammo = 0;
		}
		AmmoText.text = " " + Ammo;

		if(Input.GetKeyDown(KeyCode.RightControl)){
			Ammo = Ammo - 1;
		}
	}

	public static void AddPoints (int PointsToAdd){
		Ammo += PointsToAdd;
	}
}