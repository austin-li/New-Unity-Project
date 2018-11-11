using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

    public GameObject enemy;


    private int randx;
    private int randy;
    
    Vector2 spawnLoc;
  

    private double spawnRate = 1;
    private double nextSpawn = 0;
    private int counter = 0;
    private int signChange = 1;

	// Use this for initialization
	void Start () {
       
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextSpawn && counter < 100)
        {
            nextSpawn = Time.time + spawnRate;


           // randx1 = Random.Range(50, 75);
            //randy1 = Random.Range(50, 75);

            randx = Random.Range(-75, 75);
            if (Mathf.Abs(randx) < 50)
                randy = Random.Range(50, 75) * signChange;
            else
                randy = Random.Range(-75, 75);

            //randx2 = Random.Range(-50, -75);
            //randy2 = Random.Range(-50, -75);
            //spawnLoc1 = new Vector2(randx1, randy1);
            spawnLoc = new Vector2(randx, randy);
            //spawnLoc3 = new Vector2(randx1, randy2);
            //spawnLoc4 = new Vector2(randx2, randy1);
            //Instantiate(enemy1, spawnLoc1, Quaternion.identity);
            Instantiate(enemy, spawnLoc, Quaternion.identity);
            //Instantiate(enemy3, spawnLoc3, Quaternion.identity);
            //Instantiate(enemy4, spawnLoc4, Quaternion.identity);
            counter += 1;
            signChange *= -1;
        }
    }
}
