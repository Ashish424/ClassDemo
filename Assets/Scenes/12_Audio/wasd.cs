using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour{


	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){



		Vector3 move = Vector3.zero;
		if (Input.GetKey(KeyCode.W)){

			move.z = speed * Time.deltaTime;
			

		}
		else if (Input.GetKey(KeyCode.S)){
		
			
			
			move.z = -speed * Time.deltaTime;

		}
		else if (Input.GetKey(KeyCode.D)){
			
			move.x = speed * Time.deltaTime;

		}
		else if (Input.GetKey(KeyCode.A)){

			move.x = -speed * Time.deltaTime;

		}

		transform.position += move;
	}
}
