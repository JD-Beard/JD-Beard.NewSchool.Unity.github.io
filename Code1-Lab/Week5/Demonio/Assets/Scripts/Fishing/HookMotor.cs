using UnityEngine;
using System.Collections;

public class HookMotor : MonoBehaviour {

	Rigidbody2D RB2D;
	public float hookSpeed;
	public bool gameStart = false;
	public GameObject caughtSoul;
	public bool hasCaught;
	AudioSource Pop;


	// Use this for initialization
	void Start () {

		RB2D = GetComponent<Rigidbody2D> ();
		hasCaught = false;
		Pop = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	

		if (gameStart) {
			if (Input.GetKey (KeyCode.LeftArrow)) {

				RB2D.velocity = new Vector3 (-1f * hookSpeed, -2f, 0f);

			} else if (Input.GetKey (KeyCode.RightArrow)) {


				RB2D.velocity = new Vector3 (1 * hookSpeed, -2f, 0);
			}

			if (Input.GetKey (KeyCode.UpArrow)) {

				RB2D.velocity = new Vector3 (0, 1f*hookSpeed, 0);

			}

			if (Input.GetKey (KeyCode.DownArrow)) {


				RB2D.velocity = new Vector3 (0, -1f * hookSpeed, 0);
			}

		}
	}



	void Update(){

		if (Input.GetKey(KeyCode.Space)) {

			gameStart = true;
			RB2D.gravityScale = 0.3f;
		
		}


	}


	void OnCollisionEnter2D(Collision2D col){

	

		if (col.collider.gameObject.tag == "Enemy" && hasCaught==false) {


		    caughtSoul.SetActive (true);
			hasCaught = true;
			Pop.Play ();
			//Debug.Log (hasCaught);
			}
		}




}
