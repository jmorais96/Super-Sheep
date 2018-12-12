using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulleftPrefab;
    public Text countText;

    public int bullet = 3;

    GameObject ammunation;
    public static bool ammunationTaken;

    void Start()
    {
        SetCountText();
        
    }

    //if z is pressed start shoot function
    void Update () {


        if (Input.GetButtonDown("Fire1"))
        {
            if (bullet > 0)
            {
                Destroy(ammunation);
                bullet = bullet - 1;
                SetCountText();
                Shoot();
                FindObjectOfType<AudioManager>().Play("PlayerAttack");
            }




        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ammo")
            ammunationTaken = true;
        {
            if (bullet < 3)
            {
                int tempbullet = bullet;

                tempbullet = 3 - tempbullet;

                bullet = bullet + tempbullet;

                SetCountText();

            }
            

        }

    }

    void SetCountText()
    {
        countText.text = bullet.ToString();
    }

    //shoot function
    void Shoot()
    {
        //shooting logic
        Instantiate(bulleftPrefab, firePoint.position, firePoint.rotation);

    }

}
