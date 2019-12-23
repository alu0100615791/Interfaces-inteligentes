using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public float speed = 10f;
	public float jumpSpeed = 10f;
	public float dToGround = 0.5f;
	public float power;
	public int money;
	public Text score;
	public Text moneyText;
	
	Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		power = 0;
		money = 10;
		UpdatePowerText();
		UpdateMoneyText();
	}
	
	void Update()
	{
		
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
	
	public void IncreaseMoney()
	{
		money++;
		UpdateMoneyText();
	}
	
	public void DecreaseMoney()
	{
		money--;
		UpdateMoneyText();
	}
	
	void UpdatePowerText()
	{
		score.text = "Poder: " + power;
	}
	
	void UpdateMoneyText()
	{
		moneyText.text = "Dinero: " + money;
	}
	
	public float GetPower()
	{
		return power;
	}
	
	public void GoldPress()
	{
		power += 3;
		money -= 5;
		
		UpdatePowerText();
		UpdateMoneyText();
	}
	
	public void SilverPress()
	{
		power += 1;
		money -= 3;
		
		UpdatePowerText();
		UpdateMoneyText();
	}
}
