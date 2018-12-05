using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xlife : MonoBehaviour
{
    GameObject player;
    private void Start(){

        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter2D(Collider2D collider){

        // Life Power-Up sound
        FindObjectOfType<AudioManager>().Play("PowerUpSound");

        Destroy(gameObject);
        CtrlLife.health += 1;  
    }
}

