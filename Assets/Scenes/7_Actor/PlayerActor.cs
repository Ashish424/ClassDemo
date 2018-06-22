using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
[DisallowMultipleComponent]
public class PlayerActor : MonoBehaviour {
	private void Awake(){
		myRigidbody2D = GetComponent<Rigidbody2D>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		
	}





	public Color getColor(){

		return mySpriteRenderer.color;
		
	}

	public float getSpeed(){
		
		return myRigidbody2D.velocity.magnitude;
	}



	private SpriteRenderer mySpriteRenderer;
	private Rigidbody2D myRigidbody2D;
}
