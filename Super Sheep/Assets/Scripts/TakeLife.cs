using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLife : MonoBehaviour
{

    GameObject spawn;
    GameObject player;

    private void Start()
    {
        spawn = GameObject.Find("spawn");
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        CtrlLife.health -= 1;

        if (CtrlLife.health != 0)
        {
            player.transform.position = spawn.transform.position;
        }

    }
}

