using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
<<<<<<< HEAD:Super Sheep/Assets/PlayerMovement.cs
    public bool facingRight = false;
    public int playerJumpPower = 1250;
    public float moveX;
=======
    private bool facingRight = true;
    public int playerJumpPower;
    private float moveX;
>>>>>>> 442eba48f6ccceafafc42ced9fb65083cc091d81:Super Sheep/Assets/Scripts/PlayerMovement.cs

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
        if (moveX < 0.0f && facingRight == true){
            FlipPlayer();
        }else if (moveX > 0.0f && facingRight == false){
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
facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
    
}
