using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public int EnemySpeed;
	public int XMoveDirection;

	// Update is called once per frame
	void Update () {
		EnemySpeed = 5;
		XMoveDirection = -1;
		// RaycastHit2D hit = Physics2D.RayCast (transform.position, new Vector2 (XMoveDirection), 0);
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (XMoveDirection, 0) * EnemySpeed;
		// if (hit.distance < 1.7f) {
		// 	Flip();
		// }
	}
}
