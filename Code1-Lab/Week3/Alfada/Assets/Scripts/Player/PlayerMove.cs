using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float ShipSpeed = 2;
	public bool turn = false;
	public TrailRenderer trails;



	// Use this for initialization
	void Start () {
		trails.sortingOrder = 1;


	
	}
	
	// Update is called once per frame
	void Update () {




		if (!turn) {

			transform.Translate (0, ShipSpeed* Time.deltaTime, 0);
			transform.Rotate (0, 0, 0);


		} 
		else {
			
			transform.Translate (0, ShipSpeed * Time.deltaTime, 0);
			transform.Rotate (0, 0, 180);
		
		
		}
	
	}




	void OnCollisionEnter2D(Collision2D collider){


		if (collider.gameObject.tag == "Wall") {
			//collider.gameObject.GetComponent<FieldAnimater> ().animateField ();
			//StartCoroutine (playerScale ());
			if (turn) {

				turn = false;

			} else {

				turn = true;
			}

		}
}
}
