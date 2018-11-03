using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public GameObject sprite;
    public float moveVel = 5f;
    public float xBound = 7f;
    public float yBound = 7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < xBound)
        {
            transform.position += (Vector3.right * Time.deltaTime) * moveVel;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -xBound)
        {
            transform.position += (Vector3.left * Time.deltaTime) * moveVel;
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < yBound){
            transform.position += (Vector3.up * Time.deltaTime) * moveVel;
        }
        if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y > -yBound)
        {
            transform.position += (Vector3.down * Time.deltaTime) * moveVel;
        }
	}
}
