using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour {

	public GameObject prefab;
	public Transform spawner;
	public float repeatTime = 5;

	void Start(){
		InvokeRepeating ("spawn", 3f, repeatTime);
	}

	void spawn(){
		Instantiate (prefab, spawner.position, Quaternion.identity);
	}
}
