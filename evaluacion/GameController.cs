using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void lightsEvents();
public delegate void collisionsEvents();

public class GameController : MonoBehaviour
{
    public static GameController controller;
    public event lightsEvents turnLights;
    public static event collisionsEvents collisionB;
	public static event collisionsEvents collisionA;
	public static event collisionsEvents collisionC;
	
	private void Awake() {
        if(controller == null) {
            controller = this;
            DontDestroyOnLoad(this);
        } else if(controller != this) {
            Destroy(gameObject);
        }
    }
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnLight();
    }
	
	void TurnLight()
	{
        if (Input.GetKeyUp(KeyCode.E)) turnLights();
    }

	public static void ColA()
    {
        if(collisionA != null) collisionA();
    }
	
    public static void ColB()
    {
        if(collisionB != null) collisionB();
    }
	
	public static void ColC()
    {
        if(collisionC != null) collisionC();
    }

}
