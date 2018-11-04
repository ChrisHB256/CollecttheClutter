using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour {
    
    public float moveVel = 5f;
    public float xBound = 7f;
    public float yBound = 7f;
    public EdgeCollider2D clutterRemove;
    public float circleScale = .5f;
    public scoreCounter sCounter;
    
    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void FixedUpdate () {

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) && transform.position.x < xBound)
            {
                transform.position += (Vector3.right * Time.deltaTime) * moveVel;
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) && transform.position.x > -xBound)
            {
                transform.position += (Vector3.left * Time.deltaTime) * moveVel;
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && transform.position.y < yBound)
            {
                transform.position += (Vector3.up * Time.deltaTime) * moveVel;
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && transform.position.y > -yBound)
            {
                transform.position += (Vector3.down * Time.deltaTime) * moveVel;
            }
            OnTriggerEnter2D(clutterRemove);

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameObject.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * circleScale;
        sCounter.addScore();
    }
}
