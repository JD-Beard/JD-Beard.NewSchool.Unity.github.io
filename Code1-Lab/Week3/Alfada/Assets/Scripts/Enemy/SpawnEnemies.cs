using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	public Transform spawnPointA;
	public Transform spawnPointB;
	public Transform spawnPointC;
	public GameObject Enemies;

	//public GameObject enemy;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("spawnItem", 5f, 40f);
		InvokeRepeating ("spawnItem1",15f, 30f);
		InvokeRepeating ("spawnItem2", 10f, 15f);

	}

	// Update is called once per frame
	void Update () {

	}


	private void spawnItem(){

	
		Instantiate (Enemies,spawnPointA.transform.position,  spawnPointA.transform.rotation);

	}

	private void spawnItem1(){

		Instantiate (Enemies, spawnPointB.transform.position, spawnPointB.transform.rotation);
	}

	private void spawnItem2(){

			Instantiate (Enemies,spawnPointC.transform.position,  spawnPointC.transform.rotation);

	}
}


