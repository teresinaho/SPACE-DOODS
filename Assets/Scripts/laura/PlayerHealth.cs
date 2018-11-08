using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float max_Health = 100f;
    public float cur_Health = 0f;
    public GameObject healthBar;

	// Use this for initialization
	void Start () {

        cur_Health = max_Health;
        InvokeRepeating("decresehealth", 1f, 1f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void decresehealth(){
        cur_Health -= 2f;
        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    
    }

    public void SetHealthBar ( float myHealth){

        healthBar.transform.localScale = new Vector2 (myHealth, healthBar.transform.localScale.y);
    }

}
