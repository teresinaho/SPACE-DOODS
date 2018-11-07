using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public Image healthBar;
    public float max_health = 100F;
    public float cur_health = 0f;


	// Use this for initialization
	void Start () {

        cur_health = max_health;
        SetHealthBar();
	}

    public void TakeDamage(float amount) {

        cur_health -= amount;
        SetHealthBar();
    }
	// Update is called once per frame
	void SetHealthBar() {
        float my_health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0F, 0f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
