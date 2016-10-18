using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {

	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;
	public Animator enemyAnim;

	void Start () {
	
	}
	

	void Update () {

		//Vector3 dir = path [currentPoint].position - transform.position;

		float dist = Vector3.Distance (path [currentPoint].position, transform.position);
		transform.position = Vector3.Lerp (transform.position, path[currentPoint].position,Time.deltaTime * speed);
		transform.LookAt (path[currentPoint].position);
		enemyAnim.SetBool ("Walking", true);
	

		if (dist <= reachDist){//dir.magnitude <= reachDist) {

			currentPoint++;

		}

		if (currentPoint >= path.Length) {


			currentPoint = 0;
		}

	
	}
}
