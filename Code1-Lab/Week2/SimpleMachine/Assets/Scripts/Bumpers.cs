using UnityEngine;
using System.Collections;

public class Bumpers : MonoBehaviour {


	public float force = 100.0f;
	public float forceRadius = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(){

		foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius)) {

			if (col.GetComponent<Rigidbody>()) {

				col.GetComponent<Rigidbody>().AddExplosionForce (force, transform.position, forceRadius);
			}
		}

	}
}
