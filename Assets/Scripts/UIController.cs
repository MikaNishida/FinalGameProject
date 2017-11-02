using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIController : MonoBehaviour {

	// クリアor ゲームオーバーテキスト
	private GameObject gameEnd;

	// ゲームオーバーの判定
	private bool isGameOver = false;


	// Use this for initialization
	void Start () {
		// シーンビューからオブジェクトの実体を検索する
		this.gameEnd  = GameObject.Find ("Text");
	}
	
	// Update is called once per frame
	void Update () {
		// ジェムの数を数える
		int count = GameObject.FindGameObjectsWithTag ("GemTag").Length;

		// ゲームクリアの場合
		if(count == 0) {
			GameClear ();
		}
	}

	public void GameClear() {
		this.gameEnd.GetComponent<Text> ().text = "Clear!";
		this.isGameOver = true;
	}
}
