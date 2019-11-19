using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public float speed = 10f;
	public float jumpSpeed = 10f;
	public float dToGround = 0.5f;
	public int power;
	public Text score;
	
	Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		power = 0;
		UpdatePowerText();
	}
	
	void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.Space) && IsGrounded())
		{
			Vector3 jumpVelocity = new Vector3(0f,jumpSpeed,0f);
			rb.velocity = rb.velocity + jumpVelocity;
		}
		
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
		rb.MovePosition(transform.position + movement);
	}
	
	bool IsGrounded()
	{
		return Physics.Raycast(transform.position, Vector3.down, dToGround);
	}
	
	public void IncreasePower()
	{
		power++;
		UpdatePowerText();
	}
	
	public void DecreasePower()
	{
		power--;
		UpdatePowerText();
	}
	
	void UpdatePowerText()
	{
		score.text = "Poder: " + power;
	}
}
