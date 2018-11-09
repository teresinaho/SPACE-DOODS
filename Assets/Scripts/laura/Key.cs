using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            Debug.Log("button key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.JoystickButton1))
        {
            Debug.Log("Button key was released.");
        }
    }
}
