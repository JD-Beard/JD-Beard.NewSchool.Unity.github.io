using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CarMotor : MonoBehaviour {

	Rigidbody RB;
	public float Speed;

	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {

			RB.velocity = transform.forward * Speed;


		} else {

			if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {

				RB.velocity = Vector3.down * Speed * Time.deltaTime;
			}

		}
	}




	void OnCollisionEnter(Collision col){

		if (col.collider.gameObject.tag == "Gameover") {


			SceneManager.LoadScene ("GameOver");

		}


	}



}
