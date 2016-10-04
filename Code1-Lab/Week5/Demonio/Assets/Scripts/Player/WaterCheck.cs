using UnityEngine;
using System.Collections;

public class WaterCheck : MonoBehaviour {

	private PlayerMotor player;
	// Use this for initialization
	void Start () {
	
		player = GetComponent<PlayerMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter2D(Collider2D col){
		
			player.isGrounded = true;


	}


	void OnTriggerStay2D(Collider2D col){


		player.isGrounded = true;

	}


	void OnTriggerExit2D(Collider2D col){


		player.isGrounded = false;

	}
}
