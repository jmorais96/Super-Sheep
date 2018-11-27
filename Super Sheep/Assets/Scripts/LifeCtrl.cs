using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCtrl : MonoBehaviour {

    [SerializeField]
    public GameObject vida, vida2, vida3, gameOver;
    public static int health;
    // Use this for initialization
    void Start()
    {
        health = 3;
        vida.gameObject.SetActive(true);
        vida2.gameObject.SetActive(true);
        vida3.gameObject.SetActive(true);
        //gameOver.gameObject.SetActive.(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            health = 3;
        }
            

        switch (health)
        {
            case 3:
                vida.gameObject.SetActive(true);
                vida2.gameObject.SetActive(true);
                vida3.gameObject.SetActive(true);
                break;
            case 2:
                vida.gameObject.SetActive(true);
                vida2.gameObject.SetActive(true);
                vida3.gameObject.SetActive(false);
                break;
            case 1:
                vida.gameObject.SetActive(true);
                vida2.gameObject.SetActive(false);
                vida3.gameObject.SetActive(false);
                break;
            case 0:
                vida.gameObject.SetActive(false);
                vida2.gameObject.SetActive(false);
                vida3.gameObject.SetActive(false);
                // gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }

    }
}
