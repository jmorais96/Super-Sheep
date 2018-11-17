using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour {

    //speed variable
    public float speed;

    //defines RigidBody2D from player
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        //gets RigidBody from player
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal"); // a or left = -1 or right = 1

        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }
}
