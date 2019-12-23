using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour {

	private Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
		GameController.controller.turnLights += HandleOnOff;
	}
	
	public void HandleOnOff()
    {
        if (light.enabled == true)
        {
            light.enabled = false;
        }
        else
        {
            light.enabled = true;
        }
    }
	
}
