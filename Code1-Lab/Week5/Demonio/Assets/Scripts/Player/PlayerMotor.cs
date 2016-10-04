using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {


	public float maxSpeed = 3;
	public float speed = 50f;
	public float jumpPower = 150f;
	public bool isGrounded;
	public Transform spawnPoint;
	public GameObject bombs;
	Rigidbody2D RB2D;
	// Use this for initialization
	void Start () {

		RB2D = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}


	void FixedUpdate(){


		float h = Input.GetAxis ("Horizontal");

		RB2D.AddForce ((Vector2.right * speed) * h);

		if (RB2D.velocity.x > maxSpeed) {

			RB2D.velocity = new Vector2 (maxSpeed, RB2D.velocity.y);

		}

		if (RB2D.velocity.x < -maxSpeed) {

			RB2D.velocity = new Vector2 (-maxSpeed, RB2D.velocity.y);

		}


		if (Input.GetKeyDown (KeyCode.Space)) {

			Instantiate (bombs, spawnPoint.position, spawnPoint.rotation);
		}

	
		if (Input.GetKey (KeyCode.UpArrow) && isGrounded) {

			RB2D.AddForce (Vector2.up * jumpPower);

		}

	}




	void OnTriggerEnter2D(Collider2D col){

		isGrounded = true;
	


	}


	void OnTriggerStay2D(Collider2D col){


		isGrounded = true;

	}


	void OnTriggerExit2D(Collider2D col){


		isGrounded = false;

	}
}
