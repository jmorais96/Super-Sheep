using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    private Vector3 PosA;

    private Vector3 PosB;

    private Vector3 nexPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    [SerializeField]
    private Transform transformB;

    // Use this for initialization
    void Start () {

        PosA = childTransform.localPosition;

        PosB = transformB.localPosition;

        nexPos = PosB;

	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    private void Move()
    {
        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);

        if(Vector3.Distance(childTransform.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        nexPos = nexPos != PosA ? PosA : PosB;
    }
}
