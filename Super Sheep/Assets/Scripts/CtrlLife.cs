using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlLife: MonoBehaviour
{
    [SerializeField]
    public GameObject life, life2, life3, gameOver,Restart,Quit;
    public static int health = 3;
    // Use this for initialization
    void Start()
    {
        life.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       //Debug.Log(health);

        if (health <= 0)
        {
            gameOver.gameObject.SetActive(true);
            Restart.gameObject.SetActive(true);
            Quit.gameObject.SetActive(true);
        }
        if (health <= 4)
        {

        }

        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                life.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                break;
            case 2:
                life.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                break;
            case 1:
                life.gameObject.SetActive(true);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                break;
            case 0:
                life.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
               
                Time.timeScale = 0;
                break;

        }

    }
}
