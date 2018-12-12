using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xlife : MonoBehaviour
{
    GameObject player;
    GameObject xLife;
    public static bool xLifeTaken;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(gameObject);
        FindObjectOfType<AudioManager>().Play("PowerUpSound");
        CtrlLife.health += 1;
        xLifeTaken = true;
    }
}

