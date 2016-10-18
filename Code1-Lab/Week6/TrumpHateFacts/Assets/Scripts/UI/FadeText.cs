using UnityEngine;
using System.Collections;

public class FadeText : MonoBehaviour {

	public Animator textAnim;

	float timer;
	// Use this for initialization
	void Start () {

	
		timer = Mathf.RoundToInt (10f);

	
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer < 0) {

			textAnim.SetBool ("Fade",true);
		}
	
	}
}
