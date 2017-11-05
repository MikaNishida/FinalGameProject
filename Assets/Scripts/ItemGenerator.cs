using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	// Prefabを入れる
	public GameObject RocketPrefab;
	public GameObject BomZonePrefab;

	// アイテムを登録しておく配列を作成
	public GameObject[] ItemList;

	// ジェムを登録しておく配列を作成
	public GameObject[] GemList;


	// Use this for initialization
	void Start () {
		//アイテムをランダムにいくつ生成するか
		int count = Random.Range(2, 6);

		if (ItemList.Length != 0) {
			for (int i = 0; i < count; i++) {

				//ランダムにアイテムを決める
				int number = Random.Range (0, ItemList.Length);

				//アイテム生成
				Instantiate (ItemList [number]);
			}
		}

		// ジェムをランダムにいくつ生成するか
		int gemCount = Random.Range(4, 6);

		if(GemList.Length != 0) {
			// ジェムを生成
			for(int i = 0; i < gemCount; i++) {

				// ランダムにジェムを決める
				int gNumber = Random.Range(0, GemList.Length);

				// アイテム生成
				Instantiate (GemList [gNumber]);

			}
		}

		// Rocketとbomzoneを生成
		float rocketPosX = Random.Range (-9f, 9f);
		float rocketPosZ = Random.Range (-9f, 9f);

		GameObject rocket = Instantiate (RocketPrefab) as GameObject;
		rocket.transform.position = new Vector3 (rocketPosX, rocketPosZ, rocketPosZ);

		GameObject zone = Instantiate (BomZonePrefab) as GameObject;
		zone.transform.position = new Vector3 (0, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		
	}


}
