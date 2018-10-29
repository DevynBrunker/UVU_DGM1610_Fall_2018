using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterSwitch : MonoBehaviour {

	public bool Will;
	public bool Liz;
	public bool Lucy;

	// Use this for initialization
	void Start () {
		GetComponent<Will>();
		GetComponent<Liz>();
		GetComponent<Lucy>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.I)){
			Will.enable = true;
			Liz.enable = false;
			Lucy.enbale = false;
		}
		if(Input.GetKeyDown (KeyCode.O)){
			Will.enable = false;
			Liz.enable = true;
			Lucy.enbale = false;
		}
		if(Input.GetKeyDown (KeyCode.P)){
			Will.enable = false;
			Liz.enable = false;
			Lucy.enbale = true;
		}
	}
}
