﻿using UnityEngine;
using System.Collections;

public class PolyWater : MonoBehaviour {


	public float scale = 7.0f;
	public float heightScale = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		MeshFilter mf = GetComponent<MeshFilter>();
		Vector3[] vertices = mf.mesh.vertices;

		for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].y = heightScale * Mathf.PerlinNoise(Time.time + (vertices[i].x * scale), Time.time + (vertices[i].z * scale));
		}
		mf.mesh.vertices = vertices;
	}
}
