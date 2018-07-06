using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}



	void playAd(){


		
// ad callbacks
		
//		ShowOptions s = new ShowOptions();

//		s.resultCallback = showAd;
		
//diferent kinds of Ads		
//		Advertisement.Show();
//		Advertisement.Show("video",s);
//		Advertisement.Show("rewardedVideo",s);
		
		
	}

//	void showAd(ShowResult result){
//
//		
//		switch (result){
//				case ShowResult.Failed:
//					break;
//				case ShowResult.Finished:
//					Debug.Log("ad finished");
//					break;
//				case ShowResult.Skipped:
//					Debug.Log("ad skipped");
//					break;
//		}
//	}
	// Update is called once per frame
	void Update () {



		if (Input.GetKeyDown(KeyCode.Space)){
			playAd();	
			
			
		}
	}
	
	
	
}
