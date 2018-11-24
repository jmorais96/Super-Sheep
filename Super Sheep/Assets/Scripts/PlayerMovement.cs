using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool facingRight = false;
    public int playerJumpPower = 250;
    public float moveX;
   // public float moveY = false;
    
    void Start() {
    }

    void Update() {
        PlayerMove();
       if (gameObject.GetComponent<Rigidbody2D>().velocity.y == 0f){
            GetComponent<Animator>().SetBool("IsJumping", false);
        } 
    }

    void PlayerMove(){
    
        if (Input.GetButtonDown("Jump")){
            if (gameObject.GetComponent<Rigidbody2D>().velocity.y == 0f){
                 Jump();
            } 
           
            }
        
        //CONTROLS
        //player running
        moveX = Input.GetAxis("Horizontal");
        
        //ANIMATIONS
        if(moveX != 0.0f){
            GetComponent<Animator>().SetBool("IsRunning", true);
        } else {
            GetComponent<Animator>().SetBool("IsRunning", false);
        }
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
        GetComponent<Animator>().SetBool("IsRunning", false);
         GetComponent<Animator>().SetBool("IsJumping", true);
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
        //ANIMATOR JUMPING TRUE
       
    }

    void FlipPlayer(){
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject.name != "Spikes")
        { 
            Destroy(other.gameObject);
        }
    }
    
}
