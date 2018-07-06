using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class Poolable : MonoBehaviour {



	public virtual void reset(){
		Camera cam  = Camera.main;
		
		transform.position = new Vector3(cam.transform.position.x+cam.orthographicSize*cam.aspect,0,0);
		transform.rotation = Quaternion.identity;
		
	}
	
	

	public void move(float speed){
		transform.position += new Vector3(speed * Time.deltaTime,0,0);
	}
}
