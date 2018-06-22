using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class other : MonoBehaviour{



	[SerializeField] private PlayerActor p;
	//do not use thiis
//	[SerializeField] private GameObject t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		//this other gameoject does not rely on the individual components the player actor uses
		if (p.getColor() == Color.red && p.getSpeed() < 0.8f){
			Debug.Log("doing something");
		}
		
		
		//bad,replying on internal components
//		if (t.GetComponent<SpriteRenderer>().color == Color.red &&
//		    t.GetComponent<Rigidbody2D>().velocity.magnitude < 0.8f){
//			Debug.Log("doing something");
//		}
		
		
	}
}
