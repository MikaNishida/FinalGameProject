using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GEController : MonoBehaviour {

	// カウンター
	private float counter = 60f;

	// スタートボタン
	GameObject reStartButton;

	private bool isGameOver = false;

	// Use this for initialization
	void Start () {
		reStartButton = GameObject.Find ("reStartButton");
		reStartButton.SetActive (false);

	}

	void Update() {
		counter += Time.deltaTime;
		int count = GameObject.FindGameObjectsWithTag ("GemTag").Length;
		// ゲームクリアの場合
		if (count == 0 /*&& counter <= 60*/) {
			this.GetComponent<Text> ().text = "Clear!";
			isGameOver = true;
			reStartButton.SetActive (true);  
		}

		// ゲームオーバーの場合
//		if(count > 0 && counter > 60) {
//			this.GetComponent<Text> ().text = "Game Over!";
//			isGameOver = true;
//		}
	}
}
