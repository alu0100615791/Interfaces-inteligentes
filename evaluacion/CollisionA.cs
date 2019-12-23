using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionA : MonoBehaviour
{
	
	private Player player;
	
    // Start is called before the first frame update
    void Start()
    {
		GameObject p = GameObject.FindWithTag("Player");
        player = p.GetComponent<Player>();
    }
	
	private void OnCollisionEnter(Collision collision)
    {
        player.IncreaseMoney();
		GameController.ColA();
    }
}
