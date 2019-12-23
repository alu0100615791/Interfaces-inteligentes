using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionB : MonoBehaviour
{
	
	private Renderer rd;
	private Color defaultColor;
	private Player player;
	private float c;
	private Rigidbody rb;
	
    // Start is called before the first frame update
    void Start()
    {
		GameObject p = GameObject.FindWithTag("Player");
        player = p.GetComponent<Player>();
		
		rd = GetComponent<Renderer>();
        defaultColor = rd.material.color;
		c = 1.0f;
		
		rb = GetComponent<Rigidbody>();
		
        GameController.collisionB += handleCollisionB;
		GameController.collisionA += handleCollisionA;
		GameController.collisionC += handleCollisionC;
    }
	
	// Update is called once per frame
    void Update() {
        counter();
    }

    void handleCollisionB() {
		rd.material.color = Color.red;
		c = 1.0f;
	}
	
	void handleCollisionA() {
		float reduction = player.GetPower() / 2;
		Debug.Log ("resta " + (transform.localScale.x - reduction));
		Debug.Log ("local " + transform.localScale.x);
		Debug.Log ("num " + reduction);
        transform.localScale *= reduction;
	}
	
	void handleCollisionC() {
		Vector3 originalPosition = rb.position;
		Vector3 aux1 = new Vector3(-0.5f, 0.0f, 0.0f);
		Vector3 aux2 = new Vector3(0.5f, 0.0f, 0.0f);
		//rb.MovePosition(aux1);
		rb.MovePosition(originalPosition+aux1);
		//rb.MovePosition(aux2);
		//rb.MovePosition(originalPosition);
	}
	
	private void OnCollisionEnter(Collision collision)
    {
		if(collision.gameObject.CompareTag("Terrain"))
        {
            return;
        }
		
        GameController.ColB();
    }
	
	void counter() {
		if (c > 0) {
			c -= Time.deltaTime;
		} else if (c <= 0) {
			c = 1.0f;
			rd.material.SetColor("_Color", defaultColor);
		}
    }
}
