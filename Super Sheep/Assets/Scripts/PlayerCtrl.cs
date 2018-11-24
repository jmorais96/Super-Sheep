using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    //speed variable
    public int speed = 10;

    //defines RigidBody2D from player
   // Rigidbody2D rb;
 //   Animator anim;

    // defines jump force for player (jump hight controler)
   // public float jumpForce;
    
   // public bool grounded;

    // Use this for initialization
    void Start ()
    {

        //gets RigidBody from player
      //  rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
    
   // PlayerMove();
        
//        if (Input.GetKeyDown(KeyCode.UpArrow))
//        {
//            // set jump force to 7 (prob needs to be changed in the future)
//            jumpForce = 7f;
//
//            // the actual jump
//            rb.velocity = Vector2.up * jumpForce;
//        }
//        
    }
    
//    void PlayerMove()
//    {
//        moveX = Input.GetAxis("Horizontal");
//        //Player Direction
//        if (moveX < 0.0f && facingRight == false){
//        FlipPlayer ();
//        } else if (moveX > 0.0f && facingRight == true){
//        FlipPlayer ();
//        }
//        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
//    }
    

    void Jump()
    {
    
    }



private void FixedUpdate()
    {
//        float move = Input.GetAxis("Horizontal"); // a or left = -1 or right = 1
//
//        
//        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
