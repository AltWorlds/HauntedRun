using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour {


	private Transform transf; 
	private bool notPlaying;
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		transf = GetComponent<Transform> ();
		notPlaying = true;
		
	}

	// Update is called once per frame
	void Update () {
		//transf.position = new Vector3(transf.position.x, transf.position.y, transf.position.z-0.3f);
		if (notPlaying && transf.position.y < 0) {
			audio.loop = true;
			audio.Play ();
			notPlaying = false;

			
		} else if (transf.position.y < -70) {
			SceneManager.LoadScene ("Scene_GrassRoadRace");

		}
		
	}
}
