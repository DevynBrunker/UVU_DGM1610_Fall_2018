using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStop : MonoBehaviour {

	void Start(){
		this.GetComponent<Animator>().Play("Title", -1, 0.0f);
	}

}
