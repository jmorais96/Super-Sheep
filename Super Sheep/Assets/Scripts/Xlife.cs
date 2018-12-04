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
        Destroy(gameObject);
        CtrlLife.health += 1;  
    }
}

