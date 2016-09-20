using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour {


	public GameObject ScorePoint;
	public GameObject ScorePoint1;
	public GameObject ScorePoint2;
	public GameObject ScorePoint3;
	public GameObject Enemy;

	//public GameObject enemy;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawnItem", 2f, 5f);
		InvokeRepeating ("spawnItem1", 5f, 10f);
		InvokeRepeating ("spawnItem2", 8f, 15f);
		InvokeRepeating ("spawnItem3", 12f, 20f);
		InvokeRepeating ("spawnEnemy", 8f, 25f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private void spawnItem(){

		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (ScorePoint, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);

	}

	private void spawnItem1(){

		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (ScorePoint1, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);

	}

	private void spawnItem2(){

		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (ScorePoint2, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);

	}


	private void spawnItem3(){

		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (ScorePoint3, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);

	}

	private void spawnEnemy(){

		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (Enemy, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);


	}
}
