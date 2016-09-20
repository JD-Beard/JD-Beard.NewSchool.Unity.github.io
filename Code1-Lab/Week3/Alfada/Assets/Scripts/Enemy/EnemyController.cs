using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float ShipSpeed = 4f;
	public bool turn = false;
	public float directionChange = 2f;
	private float directionChangeInver;
	public float shotRate = 2;
	private float shotInver;
	public GameObject bullet;
	public Transform crashDeath;
	private GameObject Player;
	ScoreManager Manager;
	SoundManager Sound;







	// Use this for initialization
	void Start () {

		Manager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		Sound = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
		directionChangeInver = directionChange;

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
		directionChangeInver -= Time.deltaTime;
		if (directionChangeInver < 0) {

			MoveEnemy ();
			directionChangeInver = directionChange;

		}


		shotInver -= Time.deltaTime;
		if (shotInver < 0) {

			Shooting ();
			shotInver = shotRate;
		}





	}

	void MoveEnemy(){


		transform.Rotate (0, 0, 90f);

	}



	void Shooting(){

	
		Instantiate (bullet, transform.position, transform.rotation);
		Sound.PlaySound (6);

	}




	void OnCollisionEnter2D(Collision2D collider){


		if (collider.gameObject.tag == "Wall") {

			if (turn) {

				turn = false;

			} else {

				turn = true;
			}

		}

		if (collider.gameObject.tag == "Player") {

			Destroy (gameObject);
			Instantiate (crashDeath,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}

		if (collider.gameObject.tag == "Bullet") {

			Destroy (gameObject);
			Manager.AddScore (500);
			Sound.PlaySound (5);
			Instantiate (crashDeath,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}




	}
}