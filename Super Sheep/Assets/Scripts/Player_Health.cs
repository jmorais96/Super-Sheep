using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}

    // Death when the sheep touchs an enemy or spike
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Spikes")
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            StartCoroutine(Wait());
        }

        else if (col.gameObject.name == "Enemy")
        {
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            StartCoroutine(Wait());
        }
    }

    // Time gap after death
    IEnumerator Wait()
    {
        Debug.Log("here");
        yield return new WaitForSeconds(0f);
        SceneManager.LoadScene("GameScene");
    }


}