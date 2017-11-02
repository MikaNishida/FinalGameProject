using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// ジェムと接触した時の処理
	void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "GemTag") {
			Destroy (other.gameObject);
		}
	}
}
