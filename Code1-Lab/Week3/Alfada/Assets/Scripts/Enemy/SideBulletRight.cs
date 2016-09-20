using UnityEngine;
using System.Collections;

public class SideBulletRight : MonoBehaviour {

	public float bulletSpeed;
	public float bulletLife;

	private float shotLife;
	Rigidbody2D RB;





	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody2D> ();
		shotLife = bulletLife;
		RB.AddForce (Vector3.right * bulletSpeed);




	}

	// Update is called once per frame
	void Update () {

		shotLife -= Time.deltaTime;
		if (shotLife < 0) {

			Destroy (gameObject);

		}
	}
}