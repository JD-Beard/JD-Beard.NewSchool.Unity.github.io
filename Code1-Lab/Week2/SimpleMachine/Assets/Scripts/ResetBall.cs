﻿using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour {

	public bool ballAlive = true;
	public Transform SpawnPlace;
	public GameObject Ball;


	// Use this for initialization
	void Start () {
	
		 ballAlive = true;
	}
	
	// Update is called once per frame
	void Update () {


		if (ballAlive == false) {

			StartCoroutine (BeginBall ());

		}


		if (ballAlive == false) {

			StartCoroutine (WaitForDeath ());
		}
	}



		IEnumerator BeginBall(){


			yield return new WaitForSeconds(1);
		    Instantiate(Ball,SpawnPlace.position,Quaternion.identity);
		    ballAlive = true;

		}

	IEnumerator WaitForDeath(){
		yield return new WaitForSeconds(1);
		    ballAlive = true;
			Destroy (gameObject);


	}
	


	void OnCollisionEnter(Collision col){

		if (col.collider.tag == "OutOfBound") {

		
			ballAlive = false;


		

		}

	}
}
