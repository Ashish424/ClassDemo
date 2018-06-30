using UnityEngine;
using UnityEngine.Events;

public class PlayerEvent : MonoBehaviour {

	
	
	
	[SerializeField]UnityEvent deathEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.Space)){
			
			
			deathEvent.Invoke();
			
			
			
		}
		
	}
}
