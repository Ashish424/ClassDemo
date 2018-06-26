using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour{


	[SerializeField] private float speed = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(Vector3.forward,speed*Time.deltaTime);
	}
}
