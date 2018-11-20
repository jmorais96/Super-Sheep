using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    //speed variable
    public float speed;

    //defines RigidBody2D from player
    Rigidbody2D rb;

    // defines jump force for player (jump hight controler)
    public float jumpForce;

    // Use this for initialization
    void Start ()
    {

        //gets RigidBody from player
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // set jump force to 7 (prob needs to be changed in the future)
            jumpForce = 7f;

            // the actual jump
            rb.velocity = Vector2.up * jumpForce;
        }

    }



private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal"); // a or left = -1 or right = 1

        
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
