using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public Transform particleEF;
	// Use this for initialization
	void Start () {

		Destroy (gameObject, 5f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D otherObject){


		if (otherObject.gameObject.tag == "Player") {


			Destroy (gameObject);
			Instantiate (particleEF, new Vector3 (transform.position.x, transform.position.y, -0.2f), Quaternion.identity);

		}

	}

}
