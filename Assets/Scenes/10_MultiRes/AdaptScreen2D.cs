using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class AdaptScreen2D : MonoBehaviour {

	public enum PolicyType{
		FixedHeight,
		FixedWidth,
		Stretch
		
	}

	[SerializeField] private PolicyType policyType;
	[SerializeField] private float width;
	[SerializeField] private float camAspect;


	private void OnValidate(){
		if (camAspect < 0.1f) camAspect = 0.1f;
		if (width < 0.1f) width = 0.1f;
		

	}

	private void Awake(){
		cam = GetComponent<Camera>();
		//imp to ge the camera off the fixed height mode.
		cam.aspect = cam.aspect;
	}

	
	// Update is called once per frame
	void Update (){


		float screenAspect = 1.0f*Screen.width / Screen.height;
		switch (policyType){
			
			case PolicyType.FixedHeight:
				cam.aspect = screenAspect;
				break;
			case PolicyType.FixedWidth:
				cam.orthographicSize = 0.5f*width / screenAspect;
				cam.aspect = screenAspect;
				break;
			case PolicyType.Stretch:
				
				cam.aspect = camAspect;
				break;
				
		}
		
		
		
		
		
	}

	private void OnDestroy(){
		
		cam.ResetAspect();
		
	}


	private Camera cam;
}
