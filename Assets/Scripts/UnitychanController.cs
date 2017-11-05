using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitychanController : MonoBehaviour {
	
	// gameEndを入れる
	GameObject gameEnd;

	// gemカウントダウン
	int gemCount;

	// explosion prefab
	public GameObject Explosion;

	// アニメーションするためのコンポーネントを入れる
	private Animator myAnimator;


	// Use this for initialization
	void Start () {
		this.gameEnd = GameObject.Find ("GameEnd");
	}
	
	// Update is called once per frame
	void Update () {
		this.gemCount = GameObject.FindGameObjectsWithTag ("GemTag").Length;
		// ジェムをカウントダウンして表示
		GameObject.Find("GemCount").GetComponent<Text> ().text = ("ジェムはあと " + ((int)gemCount).ToString () + " 個");
	}


	void OnCollisionEnter(Collision other) {
		// 障害物の上でジャンプできるようにする
		if(other.gameObject.tag == "ItemTag") {
			this.myAnimator = GetComponent<Animator> ();
			this.myAnimator.SetBool ("OnGround", true);
		}
	}

	void OnTriggerEnter(Collider other) {
		// ジェムと接触した時の処理
		if(other.gameObject.tag == "GemTag") {
			this.GetComponent<ParticleSystem> ().Play ();
			Destroy (other.gameObject);

		}

		// Rocketと接触した時の処理
		if(other.gameObject.tag == "RocketTag") {
			Instantiate (Explosion, this.transform.position, transform.rotation); 
			this.gameEnd.GetComponent<Text> ().text = "Game Over!";
		}
	}
}
