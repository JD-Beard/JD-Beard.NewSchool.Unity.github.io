using UnityEngine;
using System.Collections;

public class HoverEnemy : MonoBehaviour {

	public float horizontalSpeed;
	public float verticalSpeed;
	public float amplitude;
	private Vector2 tempPosition;

	// Use this for initialization
	void Start () {


		tempPosition = transform.position;
	}

	void FixedUpdate(){

		tempPosition.x += horizontalSpeed;
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * amplitude;
		transform.position = tempPosition;


	}

	// Update is called once per frame
	void Update () {
		
	}
}
