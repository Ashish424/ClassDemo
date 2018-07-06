using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour{



	[SerializeField] private int poolSize;

	[SerializeField] private Poolable poolable;


	private void Awake(){
		pooledObjects = new List<Poolable>(poolSize);
		for (int i = 0; i < poolSize; ++i){
			pooledObjects.Add(Instantiate(poolable,Vector3.zero,Quaternion.identity));
			pooledObjects[i].reset();
		}
	}


	public void move(float speed){

		for (int i = 0; i < pooledObjects.Count; ++i){
			pooledObjects[i].move(speed);
		}
	}
	public Poolable RequestObject(){
		int prev = index;
		index = (index + 1) % pooledObjects.Count;
		
		pooledObjects[prev].reset();
		return pooledObjects[prev];

	}


	
	// Update is called once per frame
	private void Update () {
		
		move(-5);
		if (Input.GetKeyDown(KeyCode.Space)){
			RequestObject();
			
		}
		
	}

	private int index = 0;
	private List<Poolable> pooledObjects;
}
