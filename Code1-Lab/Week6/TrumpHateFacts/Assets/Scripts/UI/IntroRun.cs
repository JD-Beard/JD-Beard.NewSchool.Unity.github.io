using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroRun : MonoBehaviour {


	Animator TrumpAnim;
	// Use this for initialization
	void Start () {

		TrumpAnim = GetComponent<Animator> ();
		StartCoroutine (StartNextScene ());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	IEnumerator StartNextScene(){

		yield return new WaitForSeconds (36);
		TrumpAnim.SetBool ("StartRunning", true);


	}



	void OnCollisionEnter(Collision other){


		if (other.collider.gameObject.tag == "Wall") {


			SceneManager.LoadScene ("Level01");

		}

	}
}
