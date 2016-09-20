using UnityEngine;
using System.Collections;

public class HoverEnemy : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	public float amplitude;
	private Vector2 tempPosition;
	public Transform spawnBulletA;
	public Transform spawnBulletB;
	public GameObject bullet;

	// Use this for initialization
	void Start () {


		tempPosition = transform.position;
	}

	void FixedUpdate(){

		tempPosition.x += horizontalSpeed;
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * amplitude;
		transform.position = tempPosition;


	}

	// Update is called once per frame
	void Update () {

	
		InvokeRepeating ("Shooting", 2f, 15f);
	}




			//IEnumerator ShootingBullet(){

		//yield return new WaitForSeconds (1);
		//Instantiate (bullet, spawnBulletA.position, spawnBulletA.rotation);
		//Instantiate (bullet, spawnBulletB.position, spawnBulletB.rotation);



	//}

	private void Shooting(){


		Instantiate (bullet, spawnBulletA.position, spawnBulletA.rotation);
		Instantiate (bullet, spawnBulletB.position, spawnBulletB.rotation);


	}
}
