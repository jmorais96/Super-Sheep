using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

    // POSSÍVEL IMPLEMENTAÇÃO
    /* public LayerMask enemyMask;
    public float speed = 1;
    Rigidbody2D enemyBody;
    Transform enemyTransform;
    float enemyWidth;

    void Start()
    {
        enemyTransform = this.transform;
        enemyBody = this.GetComponent<Rigidbody2D>();
        enemyWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
    }

    void FixedUpdate()
    {   
        // Check to see if there's ground before moving forward
        Vector2 lineCastPos = enemyTransform.position - enemyTransform.right * enemyWidth;
        bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);

        // If there's no ground, flip the enemy
        if (!isGrounded)
        {
            Vector3 currRot = enemyTransform.eulerAngles;
            currRot.y += 180;
            enemyTransform.eulerAngles = currRot;
        }

        // Enemy always move forward 
        Vector2 enemyVel = enemyBody.velocity;
        enemyVel.x = -enemyTransform.right.x * speed;
        enemyBody.velocity = enemyVel;
    } */

    // ATUAL IMPLEMENTAÇÃO
    public float speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);

        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

}
