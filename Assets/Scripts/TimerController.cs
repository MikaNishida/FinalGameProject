using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerController : MonoBehaviour {

	private float restTime = 60f;
	// Use this for initialization
	void Start () {
		this.GetComponent<Text> ().text = "残り時間 " + ((int)restTime).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		restTime -= Time.deltaTime;

		// マイナスは表示しない
		if (restTime < 0) {
			restTime = 0;		
		}

		this.GetComponent<Text> ().text = "残り時間 " + ((int)restTime).ToString ();
	}
}
