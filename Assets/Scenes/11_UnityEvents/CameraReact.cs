using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReact : MonoBehaviour {
	private void Awake(){
		cam = GetComponent<Camera>();
	}

	// Use this for initialization
	void Start () {
		
	}



	public void onMainPlayerDeath(){

		StartCoroutine(_collapseScreen());
		

	}
	



	IEnumerator _collapseScreen(){

		yield return null;
		
		float maxTime = 3;
		float timer = 0;
		while (timer <= maxTime){

			float left = timer / maxTime;
			Rect camRect = cam.rect;


			float maxVal = 0.49f;
			camRect.xMin = left * maxVal;

			camRect.xMax = 1 - left * maxVal;
			

			cam.rect = camRect;
			
			timer += Time.deltaTime;
			yield return null;
			
		}

		cam.backgroundColor = Color.black;
		cam.cullingMask = 0;
		



	}

	private Camera cam;


}
