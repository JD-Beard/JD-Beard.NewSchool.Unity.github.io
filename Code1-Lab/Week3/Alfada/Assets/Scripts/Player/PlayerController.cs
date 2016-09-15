using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//public Transform particleEF;
	public Transform bulletSpawn;
    public GameObject bullet;







	void Start () {
		

	}

	// Update is called once per frame
	void Update () {



		if (Input.GetMouseButtonDown (0)) {

			if (Input.mousePosition.y <= Screen.height / 2) {

				if (Input.mousePosition.x < Screen.width / 2) {

					transform.Rotate (0, 0, 90f);
				
				} else {

					transform.Rotate (0, 0, -90f);
				
				}
			}

		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {

			transform.Rotate (0, 0, 90f);

		} 

		if (Input.GetKeyDown (KeyCode.Space)) {

			Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);


		}

	}



	void OnCollisionEnter2D(Collision2D collider){


		//if (collider.gameObject.tag == "Enemy") {

			//Destroy (gameObject);
			//Instantiate (particleEF,new Vector3(transform.position.x, transform.position.y, -0.2f), Quaternion.identity);
		}
	}

