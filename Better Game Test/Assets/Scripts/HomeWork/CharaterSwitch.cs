using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterSwitch : MonoBehaviour {

	public bool Will;
	public bool Liz;
	public bool Lucy;

	// Use this for initialization
	void Start () {
		Will = GameObject.Find("Will");
		Liz = GameObject.Find("Liz");
		Lucy = GameObject.Find("Lucy");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.I)){
			Will = true;
			Liz = false;
			Lucy = false;
		}
		if(Input.GetKeyDown (KeyCode.O)){
			Will = false;
			Liz = true;
			Lucy = false;
		}
		if(Input.GetKeyDown (KeyCode.P)){
			Will = false;
			Liz = false;
			Lucy = true;
		}
	}
}
