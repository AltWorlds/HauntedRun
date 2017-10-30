using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {


	public GameObject target;
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(transform.position.z-target.transform.position.z)>2)
			transform.position -= new Vector3(0,0,speed/10);
	}
}
