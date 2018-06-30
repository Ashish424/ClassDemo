using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	private void Awake(){
		myAudioSource = GetComponent<AudioSource>();
		
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)){
			myAudioSource.Play();
			
			
			
			
			
		}
		
	}

	private AudioSource myAudioSource;
}
