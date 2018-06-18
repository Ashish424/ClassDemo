using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("entered collision");
	}
	private void OnCollisionStay(Collision other) {
		Debug.Log("collision stay");
	}
	void OnCollisionExit(Collision other)
	{
		Debug.Log("exit collision");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
