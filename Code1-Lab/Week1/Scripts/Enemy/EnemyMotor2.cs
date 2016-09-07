using UnityEngine;
using System.Collections;

public class EnemyMotor2 : MonoBehaviour {

	public int enemyHealth;
	public float deathTimer;
	public Animator enemyAnim;
	public AudioSource hitSound;
	private EnemyChase enemyChase;
	//public GameObject Player;


	// Use this for initialization
	void Start () {

		enemyChase = GetComponent<EnemyChase>(); // Get the enemyChase script.


	}

	// Update is called once per frame
	void Update () {


		if (enemyHealth <= 0) { // if the enemy health reach 0.

			deathTimer -= Time.deltaTime; // start the death timer.
		}


		if (deathTimer < 0) { // check to see if the death timer reach 0.


			Destroy (this.gameObject); // destory the enemy
		}

		//if (enemyHealth == 0) {

			//enemyChase.enemyAlive = false;
		//}


	}



	void OnCollisionEnter(Collision collision){ //Enemy collision check!

		if (Input.GetMouseButtonUp (0) && collision.collider.tag == "Axe") { //check to see if the player weapon is attacking it.

			enemyHealth = enemyHealth - 5;
			enemyAnim.SetBool ("Hit", true);
			hitSound.Play ();
			//Debug.Log (enemyHealth);
		} else {

			enemyAnim.SetBool ("Hit", false);
		}



		if (enemyHealth == 0) {
			enemyAnim.SetBool ("Death", true);
			enemyChase.enemyAlive = false;

		}


	}

}





	