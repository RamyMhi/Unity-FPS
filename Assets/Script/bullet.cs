using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public float timer=3f;
	public float speed = 5f;
	public Score score;


	void Awake(){
		score = GameObject.FindGameObjectWithTag ("Score").GetComponent<Score> ();
	}

	// Use this for initialization
	void Start () {
		Invoke ("Die", timer);
		
	}

	void Update (){
		// update bullet position
		transform.position += transform.forward * speed * Time.deltaTime;
	}


	// call when hit to something
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("shoot");

		/// check for hit enemy
		/// and kill enemy
		/// and score
		/// bullet destroy
		if (other.tag == "Enemy") {
			CancelInvoke ();
			Destroy (other.gameObject);
			//add score
			score.Add(200);
			Debug.Log("score");
			Die();

		}
	}

	
	void Die(){
		Destroy (gameObject);
	}
}
