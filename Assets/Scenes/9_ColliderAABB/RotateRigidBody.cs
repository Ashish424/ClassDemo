using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRigidBody : MonoBehaviour{

	[SerializeField] private float speed = 10.0f;
	
	private void Awake(){
		rb = GetComponent<Rigidbody2D>();
		myBoxCollider2D = GetComponent<BoxCollider2D>();
		

	}

	// Use this for initialization
	void Start () {
		
	}

	private void FixedUpdate(){
		rb.MoveRotation(rb.rotation+speed);
		
	}

	private void OnDrawGizmos(){


		Gizmos.DrawWireCube(GetComponent<BoxCollider2D>().bounds.center,GetComponent<BoxCollider2D>().bounds.size);

		
	}



	private BoxCollider2D myBoxCollider2D;
	private Rigidbody2D rb;
}
