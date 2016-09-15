using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float bulletSpeed;





	// Use this for initialization
	void Start () {

	
	

	}

	// Update is called once per frame
	void Update () {


	
		transform.Translate (0, bulletSpeed * Time.deltaTime, 0); //* Time.deltaTime);
			



	}
}
