using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject youWinText;
    public GameObject restartOption;
    public GameObject quitOption;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "EndGameFlag")
        {
            Win();
            Time.timeScale = 0;
        }

    }

    void Win ()
    {
        FindObjectOfType<AudioManager>().Play("GameWinSound");
        youWinText.SetActive (true);
        restartOption.SetActive (true);
        quitOption.SetActive (true);
    }
}
