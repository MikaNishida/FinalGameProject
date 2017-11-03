using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.y -= 0.2f;
		if(pos.y  <= 0.07f) {
			pos.y = Random.Range(10f, 15f);
			pos.x = Random.Range (-13f, 13f);
			pos.z = Random.Range (-13f, 13f);
		}
		transform.position = pos;
	}
}