using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Transform particleEF;
	public Transform bulletSpawn;
    public GameObject bullet;
	ScoreManager Manager;
	ScreenShake Shake;
	SoundManager Sound;







	void Start () {

		Manager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		Shake = GameObject.Find ("Main Camera").GetComponent<ScreenShake> ();
		Sound = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();

	}

	// Update is called once per frame
	void Update () {



		//if (Input.GetMouseButtonDown (0)) {

		//	if (Input.mousePosition.y <= Screen.height / 2) {

				//if (Input.mousePosition.x < Screen.width / 2) {

					//transform.Rotate (0, 0, 90f);
				
				//} else {

					//transform.Rotate (0, 0, -90f);
				
				//}
			//}

		//}

		if (Input.GetKeyDown (KeyCode.UpArrow)) { 
			if (transform.position.y <= Screen.height / 2) {

				if (transform.position.x < Screen.width / 2) {
					
					transform.Rotate (0, 0, 90f);
				
				} else {
		

					transform.Rotate (0, 0, -90f);

				} 
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
			Sound.PlaySound (4);


		}

}




	void OnCollisionEnter2D(Collision2D collider){


		if (collider.gameObject.tag == "Enemy") {

			Destroy (gameObject);
			Sound.PlaySound (2);
			Manager.TakeLives (1);
			Manager.SpawnPlayer ();
			Shake.ShakeCamera (0.02f, 1f);
			Instantiate (particleEF,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}


		if (collider.gameObject.tag == "EnemyBullet") {

			Destroy (gameObject);
			Sound.PlaySound (3);
			Manager.TakeLives (1);
			Manager.SpawnPlayer ();
			Shake.ShakeCamera (0.02f, 1f);
			Instantiate (particleEF,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}
	}
}

