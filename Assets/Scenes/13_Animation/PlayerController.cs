using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private void Awake(){
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		myAnimator = GetComponent<Animator>();
		
	}


	//should move rigidbody based movement in FixedUpdate
	//doing here for simplicity.
	private void Update (){

		
		bool run = false;
		if (Input.GetKeyDown(KeyCode.Space)){
			dead = !dead;
			
		}

		float move = 0;


		if (Input.GetKey(KeyCode.D)){
			move = 5;
		}
		else if (Input.GetKey(KeyCode.A)){
			move = -5;
		}

		if (move != 0){


			run = true;
			mySpriteRenderer.flipX = move < 0 ;
			transform.position += new Vector3(move*Time.deltaTime,0,0);
			
		}
		
		myAnimator.SetBool("Run",run);
		
		//animation state updates
		myAnimator.SetBool("Dead",dead);
		
	}

	private bool dead;
	private SpriteRenderer mySpriteRenderer;
	private Animator myAnimator;
}
