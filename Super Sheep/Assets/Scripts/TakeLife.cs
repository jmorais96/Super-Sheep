using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeLife : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collider)
    {
        LifeCtrl.health -= 1;
    }
}

