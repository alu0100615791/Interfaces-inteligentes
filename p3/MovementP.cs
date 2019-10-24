using System.Collections.Generic;
using UnityEngine;

public class MovementP : MonoBehaviour
{
	
	public float moveSpeed = 3f;
	Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
		float horizontal = 0;
		float vertical = 0;
		
		if(Input.GetKey(KeyCode.I)){
			vertical = 1;
		}
		if(Input.GetKey(KeyCode.M)){
			vertical = -1;
		}
		if(Input.GetKey(KeyCode.J)){
			horizontal = -1;
		}

		if(Input.GetKey(KeyCode.L)){
			horizontal = 1;
		}
		
		Vector3 move = new Vector3 (horizontal,0,vertical) * moveSpeed * Time.deltaTime;
		rb.MovePosition(transform.position+move);
    }
}
