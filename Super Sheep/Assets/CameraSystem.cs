using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

	public GameObject player;
	private float xMin;
	private float xMax;
	private float yMin;
	private float yMax;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
