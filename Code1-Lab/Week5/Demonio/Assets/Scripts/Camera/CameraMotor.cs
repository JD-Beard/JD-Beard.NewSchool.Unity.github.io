using UnityEngine;
using System.Collections;

public class CameraMotor : MonoBehaviour {
//	[SerializeField]
//	private float xMax;
//
//	[SerializeField]
//	private float yMax;
//
//	[SerializeField]
//	private float xMin;
//
//	[SerializeField]
//	private float yMin;
//
//	public Transform target;

	private Vector2 velocity;
	public float smoothTimeY;
	public float smoothTimeX;

	public GameObject Player;
	public bool bounds;


	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;


	// Use this for initialization
	void Start () {

		//target = GetComponent<Transform> ();
		Player = GameObject.FindGameObjectWithTag("Hook");
	
	}

	// Update is called once per frame
	void FixedUpdate () {
	


		float posX = Mathf.SmoothDamp (transform.position.x, Player.transform.position.x, ref velocity.x, smoothTimeX);
		float posY = Mathf.SmoothDamp (transform.position.y, Player.transform.position.y, ref velocity.y, smoothTimeY);

	    transform.position = new Vector3 (posX, posY, transform.position.z);

		if (bounds) {

			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x), Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y), Mathf.Clamp (transform.position.z, minCameraPos.z, maxCameraPos.z));

		}



		//transform.position = new Vector3 (Mathf.Clamp (target.position.x, xMin, xMax), Mathf.Clamp (target.position.y, yMin,yMax), transform.position.z);
	}
}
