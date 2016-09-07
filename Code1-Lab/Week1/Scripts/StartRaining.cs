using UnityEngine;
using System.Collections;

public class StartRaining : MonoBehaviour {

	public GameObject Rain;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Player") 

		
			Rain.SetActive (true);
		

	}



	void OnTriggerExit(){





	}
}
