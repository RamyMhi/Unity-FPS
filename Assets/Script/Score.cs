using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score;
	public Text text;


	void Start(){
		score = 0;
		updateDisplay ();
	}

	public void Add (int value){
		score += value;
		updateDisplay ();
	}

	void updateDisplay(){
		text.text = "Score : " + score;
	}
}
