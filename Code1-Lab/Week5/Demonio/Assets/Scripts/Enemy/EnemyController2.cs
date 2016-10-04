using UnityEngine;
using System.Collections;

public class EnemyController2 : MonoBehaviour {

	public float soulSpeed = 4f;
	public bool turn = false;
	HookMotor Hook;

	void Start () {

		Hook = GameObject.Find ("FishingHook").GetComponent<HookMotor> ();

	}



	void FixedUpdate(){



		if (!turn) {

			transform.Translate (soulSpeed * Time.deltaTime, 0, 0);
			transform.Rotate (0, 0, 0);

		} else {

			transform.Translate (soulSpeed * Time.deltaTime, 0, 0);
			transform.Rotate (0, 180, 0);


		}


	}







	void OnCollisionEnter2D(Collision2D col){

		if (col.collider.gameObject.tag == "Hook" && Hook.hasCaught==false) {


			//gameObject.SetActive (false);
			Destroy(gameObject);
			//Debug.Log ("Gotch bitch");
		}

		if (col.collider.gameObject.tag == "Wall") {

			//Debug.Log ("Wall");

			if (turn) {

				turn = false;

			} else {


				turn = true;
			}

		}

	}

}
