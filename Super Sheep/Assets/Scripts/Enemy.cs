using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health= 100;

    public GameObject deathEffect;

    public void TakeDamadge (int damadge)
    {
        health -= damadge;

        if (health <= 0)
        {
            if (gameObject.name == "EnemyAlien")
            {
                Die();
            }
        }
    }

        
    void Die()
    {
        Destroy(gameObject);
    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
