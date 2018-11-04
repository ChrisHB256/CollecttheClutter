using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clutterControl : MonoBehaviour {
    public GameObject clutter;
    public float xBoundSpawn;
    public float yBoundSpawn;
    public float spawnTimer = 1f;
    private float spawnXimer;
    public float dTimer = 5f;
 
    

	// Use this for initialization
	void Start () {
        spawnXimer = spawnTimer;
	}
	
	// Update is called once per frame
	void Update () {
            spawnXimer -= Time.deltaTime;
            if (spawnXimer <= 0f)
            {
                spawnClutter();
                spawnXimer = spawnTimer;
            }
            despawnClutter();
	}
    void spawnClutter()
    {
        Instantiate(clutter, new Vector3(Random.Range(-xBoundSpawn, xBoundSpawn), Random.Range(-yBoundSpawn, yBoundSpawn), 0f), Quaternion.identity);
    }

    void despawnClutter()
    { 
        Destroy(clutter, dTimer);
    }
}
