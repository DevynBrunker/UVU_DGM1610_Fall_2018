using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoManager : MonoBehaviour {

	public static int Ammo;
	Text AmmoText;

	public GameObject Will;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();
		Ammo = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if(Ammo <= 0){
			Ammo = 0;
			Will.GetComponent<Shoot>().enabled = false;
		}
		if(Ammo >= 1){
			Will.GetComponent<Shoot>().enabled = true;
		}

		//Ammo Cap
		if( Ammo >= 30){
			Ammo = 30;
		}

		if(Input.GetKeyDown(KeyCode.RightControl)){
			Ammo = Ammo - 1;
		}

		AmmoText.text = " " + Ammo;
	}

	public static void AddAmmo (int AmmoToAdd){
		Ammo += AmmoToAdd;
	}
}