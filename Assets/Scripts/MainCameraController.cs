using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

	// プレイヤーを入れる
	private GameObject player;

	private Vector3 distance = new Vector3(0, 2, -4);

	private Vector3 lookPoint = new Vector3(0, 1.35f, 0);

	void Start () {
		this.player = GameObject.FindWithTag ("Player");
	}

	void Update () {
		this.transform.position = this.player.transform.position + distance;

		Vector3 lookVector = this.player.transform.position + lookPoint - this.transform.position;
		this.transform.rotation = Quaternion.LookRotation(lookVector);
	}
}