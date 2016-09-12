using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public AudioSource buttonS;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void ChangeToScene(string sceneToChangeTo){

		SceneManager.LoadScene (sceneToChangeTo);
		buttonS.Play ();


	}


	public void ChangeToExit(int sceneToExitTo){

		Application.Quit ();


	}
}
