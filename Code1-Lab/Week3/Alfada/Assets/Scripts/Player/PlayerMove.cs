using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float ShipSpeed = 2;
	public bool turn = false;




	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void FixedUpdate () {




		if (!turn) {

			transform.Translate (0, ShipSpeed * Time.deltaTime, 0);
			transform.Rotate (0, 0, 0);


		} 
		else {
			
			transform.Translate (0, ShipSpeed * Time.deltaTime, 0);
			transform.Rotate (0, 0, 180);
		
		
		}
	
	}




	void OnCollisionEnter2D(Collision2D collider){


		if (collider.gameObject.tag == "Wall") {
			if (turn) {

				turn = false;

			} else {

				turn = true;
			}

		}
}
}
