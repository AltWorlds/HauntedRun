using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour {


	void Update () 
	{	if (Mathf.Abs (Input.acceleration.z) > 0.1f) {
			transform.Translate (Input.acceleration.x / 10, 0, -(Input.acceleration.z / 3.5f));
	} else {
		transform.Translate(Input.acceleration.x/10, 0,0);
	}
}
}

