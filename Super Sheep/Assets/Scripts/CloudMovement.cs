using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {

    public float CloudSpeed;
    public float XMoveDirection;

    // Update is called once per frame
    void Update()
    {   
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * CloudSpeed;
    }
}
