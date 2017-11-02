using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomZoneController : MonoBehaviour {
	
	// rocketを取得
	public GameObject rocket;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject rocket = GameObject.FindGameObjectWithTag ("RocketTag");
		Vector3 pos = transform.position;
		pos.x = rocket.transform.position.x;
		pos.z = rocket.transform.position.z;
		transform.position = pos;
	}
}
