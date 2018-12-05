using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulleftPrefab;
    public int bullet = 3;

	//if z is pressed start shoot function
	void Update () {


        if (Input.GetButtonDown("Fire1"))
        {
            if (bullet > 0)
            {
                bullet = bullet - 1;
                Shoot();
                FindObjectOfType<AudioManager>().Play("PlayerAttack");
            }




        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Ammo")
        {
            if (bullet < 3)
            {
                int tempbullet = bullet;

                tempbullet = 3 - tempbullet;

                bullet = bullet + tempbullet;
                
            }
            

        }

    }

    //shoot function
    void Shoot()
    {
        //shooting logic
        Instantiate(bulleftPrefab, firePoint.position, firePoint.rotation);

    }

}
