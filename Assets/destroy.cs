using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    // Use this for initialization
    private int health;
	void Start () {
        health = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Bullet") {
            Destroy(collider.gameObject);
            health--;
            Debug.Log(health);
        }
    }
}
