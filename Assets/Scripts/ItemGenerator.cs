using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	// アイテムを登録しておく配列を作成
	public GameObject[] ItemList;


	// Use this for initialization
	void Start () {
		//ランダムにアイテムを決める
		int number = Random.Range (0, ItemList.Length);

		//アイテムをランダムにいくつ生成するか
		int count = Random.Range(10, 15);

		float posX = Random.Range (-470f, 470f);
		float posZ = Random.Range (-470f, 470f);
		Vector3 ItemPos = new Vector3 (posX, transform.position.y, posZ);

		for(int i = 0; i < count; i++) {
			Instantiate (ItemList[number], ItemPos, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
