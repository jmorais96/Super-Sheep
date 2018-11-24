using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulleftPrefab;

	//if z is pressed start shoot function
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    //shoot function
    void Shoot()
    {
        //shooting logic
        Instantiate(bulleftPrefab, firePoint.position, firePoint.rotation);

    }

}
