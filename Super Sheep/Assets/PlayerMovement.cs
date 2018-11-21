using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower;
    private float moveX;

    void Update() {
        PlayerMove();
    }

    void PlayerMove(){
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump")){
            Jump();
        }


        //ANIMATIONS
        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false){
            FlipPlayer();
        }else if (moveX > 0.0f && facingRight == true){
            FlipPlayer();
        }

        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump(){

        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
    }
    
    void FlipPlayer(){

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    
}
