using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	// Prefabを入れる
	public GameObject gemPrefab;
	public GameObject rocketPrefab;
	public GameObject bomZonePrefab;

	// アイテムを登録しておく配列を作成
	public GameObject[] ItemList;


	// Use this for initialization
	void Start () {
		//アイテムをランダムにいくつ生成するか
		int count = Random.Range(10, 15);

		if (ItemList.Length != 0) {
			for (int i = 0; i < count; i++) {
				
				//ランダムにアイテムを決める
				int number = Random.Range (0, ItemList.Length);

				//アイテムを生成する場所を決める
				float itemPosX = Random.Range (-470f, 470f);
				float itemPosZ = Random.Range (-470f, 470f);
				Vector3 ItemPos = new Vector3 (itemPosX, transform.position.y, itemPosZ);

				//アイテム生成
				Instantiate (ItemList [number], ItemPos, Quaternion.identity);
			}
		}

		// ジェムを生成
		for(int i = 0; i < 10; i++) {

			//ジェムを生成する場所を決める
			float gemPosX = Random.Range (-470f, 470f);
			float gemPosY = Random.Range (5f, 50f);
			float gemPosZ = Random.Range (-470f, 470f);

			GameObject gem = Instantiate(gemPrefab) as GameObject;
			gem.transform.position = new Vector3 (gemPosX, gemPosY, gemPosZ);
		}

		// Rocketとbomzoneを生成
		float rocketPosX = Random.Range (-470f, 470f);
		float rocketPosY = Random.Range (60f, 150f);
		float rocketPosZ = Random.Range (-470f, 470f);

		GameObject rocket = Instantiate (rocketPrefab) as GameObject;
		rocket.transform.position = new Vector3 (rocketPosX, rocketPosZ, rocketPosZ);

		GameObject zone = Instantiate (bomZonePrefab) as GameObject;
		zone.transform.position = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
