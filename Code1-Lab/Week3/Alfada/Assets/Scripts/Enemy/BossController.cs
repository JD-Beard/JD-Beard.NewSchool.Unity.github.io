using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {


	public float shotRate = 2;
	private float shotInver;
	public GameObject LeftBullet;
	public GameObject RightBullet;
	public Transform crashDeath;
	public Transform spawnBullet1;
	public Transform spawnBullet2;
	public Transform spawnBullet3;
	public Transform spawnBullet4;
	public Transform spawnBullet5;
	public Transform spawnBullet6;
	private GameObject Player;
	public int healthPoints = 20;
	ScoreManager Manager;
	SoundManager Sound;







	// Use this for initialization
	void Start () {

		Manager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		Sound = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
	
			}

	// Update is called once per frame
	void Update () {



		if (healthPoints == 0) {

			StartCoroutine (BossDef ());

		}



		shotInver -= Time.deltaTime;
		if (shotInver < 0) {

			Shooting ();
			shotInver = shotRate;
		}





	}


	IEnumerator BossDef(){
		yield return new WaitForSeconds (3);
		Instantiate (crashDeath,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		Manager.AddScore (8000);
		Sound.PlaySound (5);
		Destroy (this.gameObject);

	}






	void Shooting(){


		Instantiate (LeftBullet, spawnBullet1.transform.position, spawnBullet1.transform.rotation);
		Instantiate (LeftBullet, spawnBullet2.transform.position,spawnBullet2.transform.rotation);
		Instantiate (LeftBullet, spawnBullet3.transform.position, spawnBullet3.transform.rotation);
		Instantiate (RightBullet, spawnBullet4.transform.position, spawnBullet4.transform.rotation);
		Instantiate (RightBullet, spawnBullet5.transform.position,spawnBullet5.transform.rotation);
		Instantiate (RightBullet, spawnBullet6.transform.position, spawnBullet6.transform.rotation);
		Sound.PlaySound (6);

	}




	void OnCollisionEnter2D(Collision2D collider){




	//	if (collider.gameObject.tag == "Player") {

			//Destroy (gameObject);
			//Instantiate (crashDeath,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		//}

		if (collider.gameObject.tag == "Bullet") {

			healthPoints--;
			Instantiate (crashDeath,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}




	}
}