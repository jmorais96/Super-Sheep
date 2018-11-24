using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    public float lifetime = 2.0f; // life time of bullet 

    // Use this for initialization
    void Start () {
        rb.velocity = transform.right * speed;
	}

    //On collision with enemy
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamadge(damage);
        }
        Destroy(gameObject);
    }

    //destroys bullet after lifetime reaches 0
    void Awake()
    {
        Destroy(gameObject, lifetime);
    }

}
