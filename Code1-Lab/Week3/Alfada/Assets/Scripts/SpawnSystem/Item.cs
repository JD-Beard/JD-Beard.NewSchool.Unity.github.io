using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public Transform particleEF;

	private float timer = 4f;
	private int number;
	ScoreManager Manager;
	Animator Fadeout;
	SoundManager Sound;

	// Use this for initialization
	void Start () {
		Manager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		Sound = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
		Fadeout = GetComponent<Animator> ();
		Destroy (gameObject, 5f);
		number = Random.Range (0, 2);

	
		}
	

	void Update () {

		timer -= Time.deltaTime;

		if (timer < 0) {

			Fadeout.SetBool ("Set", true);

		}


	
	}

	void OnCollisionEnter2D(Collision2D otherObject){


		if (otherObject.gameObject.tag == "Player") {


			Destroy (gameObject);
			Manager.AddScore (500);
			Sound.PlaySound (number);
			Instantiate (particleEF, new Vector3 (transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		

		}



	}

}
