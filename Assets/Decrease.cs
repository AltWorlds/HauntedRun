using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decrease : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("c")){
			if (transform.localScale [0] >= 0) {
				transform.localScale -= new Vector3 (0.2f, 0, 0);
			}


		}
		
	}
}
