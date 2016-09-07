using UnityEngine;
using System.Collections;

public class AxeAttack : MonoBehaviour {


	public Animator animAxe;
	// Use this for initialization
	void Start () {

	

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0)){

				animAxe.SetBool ("AxeAttack", true);

			} else {
				animAxe.SetBool ("AxeAttack", false);
			}


	
	}


		


}
