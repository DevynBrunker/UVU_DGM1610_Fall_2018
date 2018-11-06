using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Move PC;
	public bool isFollowing;

	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		PC = FindObjectOfType<Move>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.postion = new Vector3(PC.transform.postion.x + xOffset, PC.transform.postion.y + yOffset, transform.postion.z);
		}
	}
}
