using UnityEngine;
using System.Collections;

public class Paddles : MonoBehaviour {


	public float force = 100.0f;
	public Vector3 offSet;
	public Vector3 forceDirection = Vector3.forward;
	public string buttonName = "Fire1";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetButton (buttonName)) {

			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * force, transform.position + offSet);
		} else {


			GetComponent<Rigidbody> ().AddForceAtPosition (forceDirection.normalized * -force, transform.position + offSet);
		}
	}
}
