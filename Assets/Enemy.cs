using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D bullet;
    
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("space")) {
            Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
            bulletInstance.velocity = 10 * Vector3.right;
            Destroy(bulletInstance, 1);
        }
    }
}
