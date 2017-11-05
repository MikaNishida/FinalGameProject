using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GEController : MonoBehaviour {

	// カウンター
	private float counter = 0f;

	// スタートボタン
	GameObject reStartButton;

	// joystick
	GameObject mobileController;

	// Use this for initialization
	void Start () {
		reStartButton = GameObject.Find ("reStartButton");
		reStartButton.SetActive (false);

		mobileController = GameObject.Find ("MobileSingleStickControl");
		mobileController.SetActive (true);
	}

	void Update() {
		counter += Time.deltaTime;
		int count = GameObject.FindGameObjectsWithTag ("GemTag").Length;
		// ゲームクリアの場合
		if (count == 0 && counter <= 60) {
			this.GetComponent<Text> ().text = "Clear!";
			reStartButton.SetActive (true); 
			mobileController.SetActive (false);

		}

		// ゲームオーバーの場合
		if(count > 0 && counter > 60) {
			this.GetComponent<Text> ().text = "Game Over!";
			reStartButton.SetActive (true);
			mobileController.SetActive (false);
		}
	}
}
