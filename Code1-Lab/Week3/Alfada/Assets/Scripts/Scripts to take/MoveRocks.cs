using UnityEngine;
using System.Collections;

public class MoveRocks : MonoBehaviour {
	public float minForce = 20f;
	public float maxForce = 40f;
	public float directionChange = 2f;

	Rigidbody2D RB;


	private float directionChangeInver;


	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody2D> ();
		directionChangeInver = directionChange;
	
		PushingRock ();

	}

	// Update is called once per frame
	void Update () {

		directionChangeInver -= Time.deltaTime;
		if (directionChangeInver < 0) {

			PushingRock ();
			directionChangeInver = directionChange;

		}



		}





	void PushingRock(){

		float force = Random.Range (minForce, maxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);

		RB.AddForce(force * new Vector2(x,y));
	}


}