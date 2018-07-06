using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour{




	public float speed;
	public bool useRigidBody;
	public int count;

	public GameObject instance;
	// Use this for initialization
	void Start () {


		for (int i = 0; i < count; ++i){
      
			var go = Instantiate(instance,Vector3.zero,Quaternion.identity,transform);

			if (useRigidBody){
				var rb = go.AddComponent<Rigidbody2D>();
				rb.isKinematic = true;
        
			}      

		}
  
  
  
  
  
    
	}
  
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < transform.childCount; ++i){


			if (useRigidBody){
				var rb = transform.GetChild(i).GetComponent<Rigidbody2D>();

        
				rb.position+=Random.insideUnitCircle*Time.deltaTime*speed;

			}
			else{
				transform.GetChild(i).position += (Vector3) Random.insideUnitCircle * Time.deltaTime * speed;
			}
		}
    
	}
}