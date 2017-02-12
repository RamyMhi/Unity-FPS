using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	// bullet point to shot
	public Transform bulletpoint;
	// bullet prefab
	public GameObject prefabBullet;


	void Update(){
		
		// 
		if (Input.GetMouseButtonDown (0)) {
			shot ();
		}

	}


	//instatiate bullet
	void shot(){


		Instantiate (prefabBullet, bulletpoint.position,bulletpoint.rotation);
	}

}
