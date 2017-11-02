using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour {

	// プレイヤーを入れる
	public GameObject player;

	// プレイヤーとカメラ間のオフセット
	private float distance;

	// Use this for initialization
	void Start () {
		this.player = GameObject.FindWithTag ("Player");
		this.distance = player.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.player.transform.position.x, this.transform.position.y, this.player.transform.position.z - distance);
		this.transform.rotation = Quaternion.Euler (0, this.player.transform.localEulerAngles.y, 0);
	}
}
