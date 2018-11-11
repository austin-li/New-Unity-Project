using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (Input.GetKey("w")) {
            rb2d.transform.position += Vector3.up * 0.1f;
        } else if (Input.GetKey("s")) {
            rb2d.transform.position += Vector3.down * 0.1f;
        }
        if (Input.GetKey("a")) {
            rb2d.transform.position += Vector3.left * 0.1f;
        } else if (Input.GetKey("d")) {
            rb2d.transform.position += Vector3.right * 0.1f;
        }

    }

    // Update is called once per frame
    void Update() {

    }
}
