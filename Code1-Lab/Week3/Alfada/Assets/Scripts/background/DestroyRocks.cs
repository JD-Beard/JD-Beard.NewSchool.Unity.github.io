using UnityEngine;
using System.Collections;

public class DestroyRocks : MonoBehaviour {

	public GameObject miniRocks;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D otherObject){


		if (otherObject.gameObject.tag == "Bullet") {


			Destroy (gameObject);
			Instantiate (miniRocks, new Vector3 (transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
			Instantiate (miniRocks, new Vector3 (transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}
}
}
