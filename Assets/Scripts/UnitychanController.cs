using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitychanController : MonoBehaviour {

	GameObject gameEnd;

	// Use this for initialization
	void Start () {
		this.gameEnd = GameObject.Find ("GameEnd");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision other) {
		// ジェムと接触した時の処理
		if(other.gameObject.tag == "GemTag") {
			Destroy (other.gameObject);
		}

		// Rocketと接触した時の処理
		if(other.gameObject.tag == "RocketTag") {
			gameEnd.GetComponent<Text> ().text = "Game Over !";
		}
	}
}
