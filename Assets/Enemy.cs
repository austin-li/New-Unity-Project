using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    public Rigidbody2D bullet;
    public Transform bulletTransform;
    public Rigidbody2D ship;

    private float fireTime;

	void Start () {
        fireTime = 1;
	}
	
	// Update is called once per frame
	void Update () {
        fireTime -= Time.deltaTime;
        if (fireTime < 0) {
            Fire();
            fireTime = 1;
        }
    }

    void Fire() {
        Rigidbody2D bulletInstance = Instantiate(bullet, bulletTransform.position, bulletTransform.rotation) as Rigidbody2D;
        Vector3 dir = ship.transform.position - transform.position;
        dir = ship.transform.InverseTransformDirection(dir);
        float angle = Mathf.Atan2(dir.y, dir.x);
        bulletInstance.transform.localScale += new Vector3(5, 5, 0);
        bulletInstance.velocity = 10 * new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
        //Destroy(bulletInstance, 1);
    }
}
