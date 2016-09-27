using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour {





	public void ChangeToScene(int SceneToChangeTo){


		SceneManager.LoadScene (SceneToChangeTo);

	}

}
