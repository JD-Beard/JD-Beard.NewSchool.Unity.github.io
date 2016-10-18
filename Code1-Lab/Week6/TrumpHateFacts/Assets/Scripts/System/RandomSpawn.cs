using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour {

	public GameObject Trump;
	public Transform[] spawnPoints;
	private int randomNum;
	// Use this for initialization
	void Start () {

		Invoke ("Spawn", 5);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn(){

		int spawnIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (Trump, spawnPoints [spawnIndex].position, spawnPoints [spawnIndex].rotation);

	}


}
