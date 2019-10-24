using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
	
	Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = new Vector3 (Random.Range(-15f,15f),0,Random.Range(-15f,15f)) * Time.fixedDeltaTime;
		rb.MovePosition(transform.position+move);
    }
}
