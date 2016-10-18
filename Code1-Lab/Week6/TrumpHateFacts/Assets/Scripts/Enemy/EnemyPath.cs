using UnityEngine;
using System.Collections;

public class EnemyPath : MonoBehaviour {

	public Transform[] pathPoints;
	public Animator enemyWalk;
	public float pathSpeed;
	public int waypoint = 0;
	Transform targetWayPoint;
	public bool waypointOn;
	public bool isAlive;
	public float gravity = 9.81f;
	//private Vector3 fallDir = Vector3.zero;




	// Use this for initialization
	void Start () {


		waypointOn = true; // start the bool when the game begins.
		isAlive = true;

	}

	// Update is called once per frame
	void Update () {

	

		if (waypointOn == true) { // if the bool is true begin path script.

			BeginPath ();
		}



		if (waypoint == 5) { // if the path gets to 3 turn off script.

			//waypointOn = false; // turn off bool.
			//enemyWalk.SetBool ("Walking", false); // turn off walking animation.
			waypoint = 0;
		}


		if (isAlive == false) {

			waypointOn = false;

		}

		//fallDir.y -= gravity * Time.deltaTime;


	}



	void PathFollow(){ // path script for the enemy.

		if (!waypointOn) // if the bool is false return and dont follow thru.
			return;


		transform.position = Vector3.MoveTowards (transform.position, targetWayPoint.position, pathSpeed * Time.deltaTime);
	
		transform.LookAt (targetWayPoint.position); // turn the enemy towards the pathpoints.

		enemyWalk.SetBool ("Walking", true);// turn on animation walk

		if (transform.position == targetWayPoint.position) { // check the waypoint position
			//transform.LookAt (targetWayPoint.position);
			waypoint++; // +1 to the waypoint to move.

			targetWayPoint = pathPoints [waypoint]; // This make the enemy follow the path using array.

		}




	}


	void BeginPath(){ //begin the searching for the path.
		if (!waypointOn) // if the bool is false turn off.
			return;

		if (waypoint < this.pathPoints.Length) { // the way point is less then the pathpoint begin.

			if (targetWayPoint == null) // if the path point is null do this.
				targetWayPoint = pathPoints [waypoint]; // the enemy target path is the waypoints.
			PathFollow (); // start following the path.

		}
	}









}
