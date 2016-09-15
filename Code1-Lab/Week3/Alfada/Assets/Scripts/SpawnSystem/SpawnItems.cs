using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour {


	public GameObject pickUpItems;
	//public GameObject enemy;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawnItems", 2f, 15f);
		//InvokeRepeating ("spawnEnemy", 5f, 9f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private void spawnItems(){

		Vector2 spawnpoint = Random.insideUnitCircle * 5.00f;
		Instantiate (pickUpItems, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);

	}

	//private void spawnEnemy(){

		//Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		//Instantiate (enemy, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);


	//}
}
