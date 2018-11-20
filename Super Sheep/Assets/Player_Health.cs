﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {

	public int health;
	public bool hasDied;

	// Use this for initialization
	void Start () {
		hasDied = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -5.84) { 
			hasDied = true;
		}
		if (hasDied == true) {
			StartCoroutine ("Die");
		}
	}

	IEnumerator Die () {
		SceneManager.LoadScene ("MainTests");
		yield return null;
	}

}
