using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour {


	float accZ = 0f;
	void Update () 
	{	
		accZ = Input.acceleration.z;
		if (accZ > 0) {
			accZ -= 3;
		}
		else  {
			accZ += 3;
		}
		accZ /= 10;
		transform.Translate(0, 0, -accZ);
	}
}
