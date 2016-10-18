using UnityEngine;
using System.Collections;

public class Destroyeffect : MonoBehaviour {



	public float factSpeed;
//	public float factLife;
//	private float thisFactLife;
	Rigidbody RB;



	void Start () {
		Destroy (gameObject, 2f);
		RB = GetComponent<Rigidbody> ();
		RB.velocity = Camera.main.transform.forward * factSpeed;
//		thisFactLife = factLife;
	}
	

	void Update () {

//		thisFactLife -= Time.deltaTime;
//		if (thisFactLife < 0) {
//
//			Destroy (gameObject);
//
//		}
	
	}



	void OnCollisionEnter(Collision other){

		if (other.collider.gameObject.tag == "Enemy") {

			Destroy (gameObject);


		}



	}

}
