﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootTrigger : MonoBehaviour {


	public float force = 100.0f;
	public string buttonName = "Fire1";
	public AudioSource shootEffect;

	private List<Rigidbody> ballList = new List<Rigidbody> ();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.Space)) {


			foreach (Rigidbody ball in ballList) {

				ball.AddForce (Vector3.forward * force, ForceMode.VelocityChange);
				shootEffect.Play ();
			}

		}
	}



	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Rigidbody> ()) {

			ballList.Add (col.GetComponent<Rigidbody> ());
		}

	}



	void OnTriggerExit(Collider col){

		if (col.GetComponent<Rigidbody> ()) {

			ballList.Remove (col.GetComponent<Rigidbody> ());
		}

	}
}
