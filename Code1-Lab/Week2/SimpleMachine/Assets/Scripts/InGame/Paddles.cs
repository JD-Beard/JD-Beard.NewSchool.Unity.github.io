using UnityEngine;
using System.Collections;

public class Paddles : MonoBehaviour {


	public float force = 100.0f;
	public Vector3 offSet;
	public Vector3 forceDirection = Vector3.forward;
	public AudioSource paddleSound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey("left")) {

			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * force, transform.position + offSet);
			paddleSound.Play ();
		} else {


			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * -force, transform.position + offSet);
		}
	}
}
