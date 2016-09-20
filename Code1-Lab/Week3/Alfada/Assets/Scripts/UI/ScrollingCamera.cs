using UnityEngine;
using System.Collections;

public class ScrollingCamera : MonoBehaviour {


	public float cameraSpeed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (cameraSpeed * Time.deltaTime, 0, 0);
	
	}
}
