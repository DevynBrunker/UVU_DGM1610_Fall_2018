using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopTest2 : MonoBehaviour {

	public int Apple;
	public int Orange;
	private int AO;
	

	// Use this for initialization
	void Start () {
		AO = Apple + Orange;
		print("Apple + Orange = ");
		print(AO);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
