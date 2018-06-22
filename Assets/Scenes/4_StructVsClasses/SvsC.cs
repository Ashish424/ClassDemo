using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvsC : MonoBehaviour {



	
	
	class TestClass{


		public float x;
		public float y;

	} 
    struct TestStruct{

	    public float x;
	    public float y;


    }

	// Use this for initialization
	void Start () {
		
	
		TestClass tc = new TestClass();
		TestClass tc2 = tc;
		tc2.x =4;
		
		Debug.Log("value of tc.x "+tc.x+ " value of tc2.x "+tc2.x);
		
		
		TestStruct tS = new TestStruct();
		TestStruct tS2 = tS;
		tS2.x = 2;
//common structs used in Unity
//		Vector3 z = new Vector3(0, 0, 1);
//		Quaternion q = new Quaternion(0,0,0,1);
		

		Debug.Log("value of ts.x "+tS.x+ " value of ts2.x "+tS2.x);




	}
	
}
