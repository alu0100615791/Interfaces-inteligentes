using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	
	public float moveSpeed = 3f;
	public float rotationSpeed = 20f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float moves = Input.GetAxis("Vertical") * moveSpeed;
        float rotates = Input.GetAxis("Horizontal") * rotationSpeed;
        moves *= Time.deltaTime;
        rotates *= Time.deltaTime;
        transform.Translate(0, 0, moves);
        transform.Rotate(0, rotates, 0);
    }
}
