using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class evil : MonoBehaviour {
	// use mash agent for auto target
	public NavMeshAgent agent;

	//target transform
	public Transform Target;

	// first func after run 
	void Awake(){
		
		Target = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void OnTriggerEnter(Collider other){
		Debug.Log (other.tag);
		if (other.tag == "Player") {
			Debug.Log ("dead");
			SceneManager.LoadScene (0);
		}
		
	}
	void Update(){
		agent.SetDestination (Target.position);
	}
}
