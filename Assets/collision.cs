using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay2D(Collider2D col) {
        if (col.gameObject.tag == "Player" && GameObject.Find("P1").GetComponent<P1>().station1 == false) {
            col.gameObject.transform.position = new Vector3(-6.883f, -0.339f, 0);
            GameObject.Find("P1").GetComponent<P1>().station1 = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
    }
}
