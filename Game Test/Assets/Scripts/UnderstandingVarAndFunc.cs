using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	//You always need a class for a script
public class UnderstandingVarAndFunc : MonoBehaviour {

	/* To make a variable: 
	access modifier(public/private) type(int/float/bool) name of
	variable(any name) and or a value (whole numbers) */
	public int Abby = 5;	//int means whole number (7 8 9)
	public float Buck;		//float means numbers with a fractional part (5.7 6.3 9.9)
	private bool chad;		//bool means true or false

	Buck = 4.5;

	printf("How old is Buck");
	scanf("%f", &Buck);
	printf("Buck is %f\n", Buck);

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
