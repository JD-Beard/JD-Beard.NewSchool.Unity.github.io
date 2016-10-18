using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSpeech : MonoBehaviour {

	public Transform spawnPoint;
	public ParticleSystem effect;
	public ParticleSystem HitEffect;
	public AudioClip[] audioClip;
	private bool isFinish = true;
	private int randomNumber;
	public int MyLife = 3;
	public Image live;
	public Image live1;
	public Image live2;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		randomNumber = Random.Range (0, 3);


		if (Input.GetMouseButtonDown (0)&& isFinish==true) {


			Instantiate (effect, spawnPoint.position, spawnPoint.rotation);
			PlaySound (randomNumber);
			StartCoroutine (CheckingTime ());
			isFinish = false;

		}


		if (MyLife == 2) {

			live.enabled = false;

		}

		if (MyLife == 1) {

			live1.enabled = false;

		}

		if (MyLife == 0) {

			live2.enabled = false;

		}
	
	}



	public void PlaySound(int clip){

		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioClip [clip];
		audio.Play ();


	}




	IEnumerator CheckingTime(){

		yield return new WaitForSeconds (2);
		isFinish = true;

	}

	IEnumerator GameOver(){

		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("Gameover");

	}



	void OnCollisionEnter(Collision other){

		if (other.collider.gameObject.tag == "Club") {

			MyLife--;
			PlaySound (3);
			Instantiate (HitEffect, transform.position, transform.rotation);

			if (MyLife == 0) {

				StartCoroutine (GameOver ());



			}

		}


	}


}