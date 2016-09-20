using UnityEngine;
using System.Collections;

public class TeleportPlayer : MonoBehaviour {

	float MinX = -10f;
	float MaxX = 10f;
	float MinY = -7f;
	float MaxY = 7f;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void FixedUpdate(){



		float x = transform.position.x;
		float y = transform.position.y;

		if (x < MinX)
			x = MaxX;
		else if (x > MaxX)
			x = MinX;

		if (y < MinY)
			y = MaxY;
		else if (y > MaxY)
			y = MinY;

		transform.position = new Vector3 (x, y, transform.position.z);


	}
}
