using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {


	public float scoreCount;
	public float pointsPerSecond;
	public bool scoreIncreasing;
	public Text scoreText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreIncreasing) {

			scoreCount += pointsPerSecond * Time.deltaTime;
		}

		scoreText.text = "Score: " + Mathf.Round (scoreCount);
	
	}
}
