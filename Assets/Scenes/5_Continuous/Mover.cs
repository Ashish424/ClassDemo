using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour{



	[Range(0,4000)][SerializeField] private float speed;


	
	
	private void Awake(){

		myRigidbody2D = GetComponent<Rigidbody2D>();

		myRigidbody2D.AddForce(new Vector2(-speed,0),ForceMode2D.Impulse);
		
		//can use this as well since for single frame only.
//		myRigidbody2D.velocity = new Vector2(-speed,0);


	}
	
	
	
	

	private Rigidbody2D myRigidbody2D;

}
