using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public float moveSpeed = 3f;
	Rigidbody rb;
	int count = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");

        Vector3 move = new Vector3 (horizontal,0,vertical) * moveSpeed * Time.deltaTime;
		rb.MovePosition(transform.position+move);
    }
	
	private void OnCollisionEnter(Collision collision)
    {
		count++;
		print("El numero de colisiones es de " + count);
	}
}
