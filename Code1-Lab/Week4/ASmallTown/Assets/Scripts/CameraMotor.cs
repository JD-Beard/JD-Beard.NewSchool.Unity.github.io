using UnityEngine;
using System.Collections;

public class CameraMotor : MonoBehaviour {


	private Transform lookAtPlayer;
	private Vector3 startOffSet;
	private Vector3 moveCamera;

	private float transition = 0.0f;
	private float animationDuration = 1.0f;
	private Vector3 animationOffSet = new Vector3 (0,5,2);
	// Use this for initialization
	void Start () {

		lookAtPlayer = GameObject.FindGameObjectWithTag ("Player").transform;
		startOffSet = transform.position - lookAtPlayer.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		moveCamera = lookAtPlayer.position + startOffSet;
		moveCamera.x = -6.241f;
		moveCamera.y = Mathf.Clamp (moveCamera.y, 1, 3);

		if (transition > 1.0f) {

			transform.position = transform.position = moveCamera; //move the camera in this position.


		} else { // else do this.
			transform.position = Vector3.Lerp (moveCamera + animationOffSet, moveCamera, transition); // move the camera in all above refs.
			transition += Time.deltaTime * 1 / animationDuration; // timer for the animation.
			transform.LookAt(lookAtPlayer.position + Vector3.up); // look at the person after the animation.
		}

		}
	
	}

