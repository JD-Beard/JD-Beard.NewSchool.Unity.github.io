using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float minForce = 20f;
	public float maxForce = 40f;
	public float directionChange = 2f;
	public float shotRate = 5f;
	public GameObject bullet;
	private GameObject Player;


	Rigidbody2D RB;


	private float directionChangeInver;
	private float shotInver;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody2D> ();
		directionChangeInver = directionChange;
		shotInver = shotRate;
		PushingShip ();
	
	}
	
	// Update is called once per frame
	void Update () {

		directionChangeInver -= Time.deltaTime;
		if (directionChangeInver < 0) {

			PushingShip ();
			directionChangeInver = directionChange;

		}


		shotInver -= Time.deltaTime;
		if (shotInver < 0) {

			Shooting ();
			shotInver = shotRate;
		}
	
	}



	void PushingShip(){

		float force = Random.Range (minForce, maxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);

		RB.AddForce(force * new Vector2(x,y));
	}



	void Shooting(){

		Player = UnityEngine.GameObject.FindGameObjectWithTag ("Player");
		float angle = (Mathf.Atan2 (Player.transform.position.y - transform.position.y,Player.transform.position.x - transform.position.x) - Mathf.PI / 2) * Mathf.Rad2Deg;

		Instantiate (bullet, transform.position, Quaternion.Euler (new Vector3 (0f, 0f, angle)));

	}
}
