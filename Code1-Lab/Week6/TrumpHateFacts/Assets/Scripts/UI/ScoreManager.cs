using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	float Timer;
	public Text clockTime;
	private bool BeginTimer;

	// Use this for initialization
	void Start () {

		clockTime.text = "Timer : " + Timer;
		BeginTimer = false;
		Timer = Mathf.RoundToInt (200f);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W)) {

			BeginTimer = true;

		}

		if (BeginTimer == true) {

			Timer -= Time.deltaTime;

		}

		clockTime.text = "Timer : " + Timer.ToString ("f0");


		if (Timer < 0) {

			SceneManager.LoadScene ("Gameover");

		}
	
	}
}
