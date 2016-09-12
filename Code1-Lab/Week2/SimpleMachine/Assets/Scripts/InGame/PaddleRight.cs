using UnityEngine;
using System.Collections;

public class PaddleRight : MonoBehaviour {

	public float force = 100.0f;
	public Vector3 offSet;
	public Vector3 forceDirection = Vector3.forward;
	public AudioSource paddleSound;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKey("right")) {

			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * force, transform.position + offSet);
			paddleSound.Play ();
		} else {


			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * -force, transform.position + offSet);
		}
	}
}