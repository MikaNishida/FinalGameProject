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
		pos.y -= 2f;
		if(pos.y  <= 0.07f) {
			pos.y = Random.Range(50f, 150f);
			pos.x = Random.Range (-470f, 470f);
			pos.z = Random.Range (-470f, 470f);
		}
		transform.position = pos;
	}
}