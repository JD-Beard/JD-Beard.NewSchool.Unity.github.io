using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PopUpMessage : MonoBehaviour {

	public Canvas PopUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}





	void OnTriggerEnter(){

		PopUp.gameObject.SetActive (true);

	}


	void OnTriggerExit(){

		PopUp.gameObject.SetActive (false);

	}




	IEnumerator GatherAxe(){
		yield return new WaitForSeconds (3);


	}
}
