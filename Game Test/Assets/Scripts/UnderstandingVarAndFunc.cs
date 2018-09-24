using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	//You always need a class for a script
public class UnderstandingVarAndFunc : MonoBehaviour {

	/* To make a variable: 
	access modifier(public/private) type(int/float/bool) name of
	variable(any name) and or a value (whole numbers) */
	public int Abby = 5;	//int means whole number (7 8 9)
	public double Buck;		//double means numbers with a fractional part (5.7 6.3 9.9)
	private bool chad;		//bool means true or false

	// Use this for initialization
	/*functions go in either void start or void update*/
	void Start () {

	Buck = 4.5;

	print("How old is Buck");
	print("Buck is %f\n", Buck);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
