using UnityEngine;
using System.Collections;

public class EnemyChase : MonoBehaviour {

	public Transform Player; 
	public Animator anim;
	public float followSpeed;
	public float followRadius;
	public float stopFollowing;
	public bool follow;
	public bool enemyAlive;
	public bool touchPlayer;

	// Use this for initialization
	void Start () {
		
		follow = false; // following the player turn off.
		enemyAlive = true; //The enemy is alive.
		touchPlayer = false;

	}
	
	// Update is called once per frame
	void Update () {

	
		if (enemyAlive == true && touchPlayer == false) {

			FollowPlayer ();
		}

		if (enemyAlive == false) {

			StopFollowing ();

		}

	
		if (touchPlayer == true) {

			transform.Translate (Vector3.zero); // turn off movement of the enemy.
			anim.SetBool ("Walking", false);
			StartCoroutine (BeginFollowing ());
		}


	
	}



	void FollowPlayer(){

		if (Vector3.Distance (transform.position, Player.position) < followRadius) // checking to see the player location, to begin to follow.
			follow = true; // turn on follow.



		if (follow) { // if the radius is correct begin following.
			transform.LookAt (Player);  // when following make sure to face the player.
			transform.Translate (Vector3.forward * followSpeed * Time.deltaTime); // move the enemy towards the player.
			anim.SetBool ("Walking", true); // turn on the walking animation.

		} else {


			if (!follow) { // if not in the Player radius dont follow.

				transform.Translate (Vector3.zero); // turn off movement of the enemy.
				anim.SetBool ("Walking", false); // turn off walking animation.
			}

		}

		if (Vector3.Distance (transform.position, Player.position) >= stopFollowing) { // the radius of the Player to stop following.

			follow = false; // turn follow off.
		

		}




	}



	void StopFollowing(){



	
			transform.Translate (Vector3.zero); // turn off movement of the enemy.
			anim.SetBool ("Walking", false);
		    follow = false;


	}





	void OnCollisionEnter(){


		touchPlayer = true;

	}


	IEnumerator BeginFollowing(){
		yield return new WaitForSeconds (5);
		touchPlayer = false;

	}


	void OnTriggerEnter(){


		touchPlayer = true;
	}

	void OnTriggerExit(){


		touchPlayer = false;

	}

}



