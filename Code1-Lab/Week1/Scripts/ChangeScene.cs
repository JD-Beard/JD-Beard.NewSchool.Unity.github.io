using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene(string sceneToChangeTo){
		SceneManager.LoadScene (sceneToChangeTo);

	}

	public void QuitScene(){


		Application.Quit ();
	}
}
