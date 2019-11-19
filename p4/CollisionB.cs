using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionB : MonoBehaviour
{
	
	private Renderer rd;
	private Color defaultColor;
	private Player player;
	private float c;
	
    // Start is called before the first frame update
    void Start()
    {
		GameObject p = GameObject.FindWithTag("Player");
        player = p.GetComponent<Player>();
		
		rd = GetComponent<Renderer>();
        defaultColor = rd.material.color;
		c = 1.0f;
		
        GameController.collisionB += handleCollisionB;
    }
	
	// Update is called once per frame
    void Update() {
        counter();
    }

    void handleCollisionB() {
		rd.material.color = Color.red;
		c = 1.0f;
	}
	
	private void OnCollisionEnter(Collision collision)
    {
		player.DecreasePower();
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
