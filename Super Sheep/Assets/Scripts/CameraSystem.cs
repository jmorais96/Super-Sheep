﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {
	
	private GameObject player;
	public float xMin = 1;
	public float xMax = 400;
	public float yMin = -30;
	public float yMax = 100;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
		float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);
		gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
	}
}
