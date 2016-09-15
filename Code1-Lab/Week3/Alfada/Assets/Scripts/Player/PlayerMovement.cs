﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float turningSpeed;
	public float BurstForce;
	Rigidbody2D RB;
	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

		if (Input.GetKey (KeyCode.LeftArrow)) {

			RB.angularVelocity = turningSpeed;


		} else if (Input.GetKey (KeyCode.RightArrow)) {
			

			RB.angularVelocity = -turningSpeed;

		} else {

			RB.angularVelocity = 0f;

		}

		if (Input.GetKey (KeyCode.UpArrow)) {


			RB.AddForce (transform.up * BurstForce);

		}


	}
}
