using UnityEngine;
using System.Collections;

public class CaughtSoul : MonoBehaviour {

	ScoreManager Score;
	HookMotor Hook;
	public GameObject PowerUp;
	public Transform Demon;
	public AudioSource Laugh;

	// Use this for initialization
	void Start () {
		Score = GameObject.Find ("SoulCollecter").GetComponent<ScoreManager> ();
		Hook = GameObject.Find ("FishingHook").GetComponent<HookMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnCollisionEnter2D(Collision2D col){

		if (col.collider.gameObject.tag == "SoulCollecter") {

			Score.AddScore (1);
			gameObject.SetActive (false);
			Hook.hasCaught = false;
			Instantiate (PowerUp, Demon.transform.position, Demon.transform.rotation);
			Laugh.Play ();

		}

}
}
