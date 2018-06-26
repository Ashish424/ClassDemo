using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faller : MonoBehaviour{

	[SerializeField]private bool useFixedUpdate;
	[Range(1,100)][SerializeField]private float move;



	private void Awake(){
		initPosition = transform.position;
	}


	private void FixedUpdate(){
		if (useFixedUpdate){
			
			

			//time.deltatime return fixed time value in fixed update.
			transform.position += new Vector3(move*Time.fixedDeltaTime,0);

			if (frameCount == 100){
				Debug.Log("dsiplace is "+(transform.position-initPosition).magnitude);
			}
			++frameCount;
		}

	}


	//
	// Update is called once per frame
	void Update () {
		if (!useFixedUpdate){


			transform.position += new Vector3(move*Time.deltaTime,0);
			
			if (frameCount == 100){
				
				Debug.Log("dsiplace is "+(transform.position-initPosition).magnitude);
			}
			++frameCount;
		}

		
	}



	private int frameCount = 0;

	private Vector3 initPosition;
}
