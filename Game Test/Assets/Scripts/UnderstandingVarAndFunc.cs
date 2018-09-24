using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	//You always need a class for a script
public class UnderstandingVarAndFunc : MonoBehaviour {

	/* To make a variable: 
	access modifier(public/private) type(int/float/bool) name of
	variable(any name) and or a value (whole numbers) */
	public int Abby = 5;
	public float Buck;
	private bool Chad;

	// Use this for initialization
	/*functions go in either void start or void update*/
	void Start () {

		//doing debug.log allows me to see whats going on in the console in Unity
		debug.log (Abby);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
