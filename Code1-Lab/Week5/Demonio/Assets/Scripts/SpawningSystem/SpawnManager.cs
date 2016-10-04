using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {


	public Transform spawnPointA;
	public Transform spawnPointB;
	public Transform spawnPointC;
	public Transform spawnPointD;
	public GameObject enemy;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawnEnemy", 5f, 5f);
		InvokeRepeating ("spawnEnemy1", 5f, 10f);
		InvokeRepeating ("spawnEnemy2", 10f, 10f);
		InvokeRepeating ("spawnEnemy3", 15f, 20f);
	
	}
	
	// Update is called once per frame
	void Update () {

	}



	private void spawnEnemy(){

		Instantiate (enemy, spawnPointA.transform.position, spawnPointA.transform.rotation);

	}

	private void spawnEnemy1(){

		Instantiate (enemy, spawnPointB.transform.position, spawnPointB.transform.rotation);

	}

	private void spawnEnemy2(){

		Instantiate (enemy, spawnPointC.transform.position, spawnPointC.transform.rotation);

	}
	private void spawnEnemy3(){

		Instantiate (enemy, spawnPointD.transform.position, spawnPointD.transform.rotation);

	}
}
