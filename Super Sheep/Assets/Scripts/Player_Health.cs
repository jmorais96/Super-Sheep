using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -200) { 
			Die ();
		}
	}

    // Death when the sheep touchs an enemy or spike
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Spikes")
        {
            System.Threading.Thread.Sleep(300);

            // Death sound
            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            Die();
        } else if (col.gameObject.name == "Enemy")
        {
            System.Threading.Thread.Sleep(300);
            Die();
        }
    }

    // Death method
    void Die()
    {
        SceneManager.LoadScene("GameScene");
    }

}
