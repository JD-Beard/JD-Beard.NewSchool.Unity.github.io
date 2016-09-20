using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	int score = 0;
	int Lives = 3;
	public Text scoreText;
	public Text livesText;
	public GameObject spawnNewPlayer;

	// Use this for initialization
	void Start () {

		scoreText.text = "Score: " + score;
		livesText.text = "Lives : " + Lives;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Lives == 0) {

			StartCoroutine (LoadGameOverScene ());
		}
	
	}




	public void AddScore(int pointsToAdd){


		score = score + pointsToAdd;
		scoreText.text = "Score: " + score;


	}

	public void TakeLives(int pointsToTake){


		Lives = Lives - pointsToTake;
		livesText.text = "Lives: " + Lives;


	}


	public void SpawnPlayer(){


		if (Lives > 0) {

			StartCoroutine (StartSpawn ());
		}

	}

		IEnumerator StartSpawn(){

		yield return new WaitForSeconds (2);
		Vector2 spawnpoint = Random.insideUnitCircle * 3.00f;
		Instantiate (spawnNewPlayer, new Vector3 (spawnpoint.x, spawnpoint.y, 0), Quaternion.identity);
		}

	IEnumerator LoadGameOverScene(){
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene ("Gameover");


	}


}
