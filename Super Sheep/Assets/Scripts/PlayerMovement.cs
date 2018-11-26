using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{

    
    public Animator animator;
    public int playerSpeed = 10;
    public bool facingRight = false;
    public int playerJumpPower = 250;
    public float moveX;



    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update() {

        PlayerMove();

    }

    void PlayerMove(){
    
        if (Input.GetButtonDown("Jump")){
            

            if (gameObject.GetComponent<Rigidbody2D>().velocity.y == 0f)
            {
               
                Jump();
                
            }

        }
        
        //CONTROLS

        //player running
        moveX = Input.GetAxis("Horizontal");

        //PLAYER DIRECTION
        if (moveX < 0.0f && facingRight == false){
            FlipPlayer();
        }else if (moveX > 0.0f && facingRight == true){
            FlipPlayer();
        }

       

        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(moveX));
    }

    void Jump(){

       
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);

      


        //ANIMATOR JUMPING TRUE

    }

    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }


    void FlipPlayer(){

        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject.name != "Spikes")
        { 
            Destroy(other.gameObject);
        }
    }
    
}
