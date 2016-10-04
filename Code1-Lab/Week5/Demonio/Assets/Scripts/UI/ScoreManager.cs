using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	int soulScore = 0;
	float Timer;
	public Text scoreText;
	public Text clockTime;
	private bool BeginTimer;

	// Use this for initialization
	void Start () {

		scoreText.text = "Collect Souls : " + soulScore;
        clockTime.text = "Timer : " + Timer;
		BeginTimer = false;
		Timer = Mathf.RoundToInt (60f);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey(KeyCode.Space)) {


			BeginTimer = true;

		}

		if (BeginTimer ==true){

			Timer -=Time.deltaTime;

		}

		clockTime.text = "Timer : " + Timer.ToString ("f0");


		if (Timer < 0) {

			SceneManager.LoadScene ("Gameover");
			//Debug.Log ("GameOver");
		}


		if (soulScore == 6) {


			StartCoroutine (GoIntoGameOver ());

		}
	
	}




	public void AddScore(int pointsToAdd){

		soulScore = soulScore + pointsToAdd;
		scoreText.text = "Collect Souls : " + soulScore;


	}



	IEnumerator GoIntoGameOver(){

		yield return new WaitForSeconds (2);

		SceneManager.LoadScene ("Gameover");
	}




}
