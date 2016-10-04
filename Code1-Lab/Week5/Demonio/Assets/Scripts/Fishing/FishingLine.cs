using UnityEngine;
using System.Collections;

public class FishingLine : MonoBehaviour 
{


	private LineRenderer lineRenderer;
//	private float counter;
	//private float dist;
	public Transform rod;
	public Transform hook;
	//public float lineDrawSpeed = 6f;



	// Use this for initialization
	void Start () {

		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.sortingOrder = 1;


	
	}

	// Update is called once per frame
	void Update () {

			
			
		lineRenderer.SetPosition (0, rod.position);
		lineRenderer.SetWidth(.04f,.04f);
			
       // dist = Vector2.Distance (rod.position, hook.position);
//			
//		if (counter < dist) {
//			
//			counter += .1f / lineDrawSpeed * Time.deltaTime;
//			
//			float x = Mathf.Lerp (0, dist, counter);
//			
//			Vector2 pointA = rod.position;
//			Vector2 pointB = hook.position;
//			
//			
//			Vector2 pointAlongLine = x * Vector3.Normalize (pointB - pointA) + pointA;
//			
		lineRenderer.SetPosition (1, hook.position);
//			






		}












		}




	





