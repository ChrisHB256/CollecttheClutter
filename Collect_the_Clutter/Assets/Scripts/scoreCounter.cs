using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour {
    private int score = 0;
    public Text scoreUI;

	// Use this for initialization
	void Start () {
       scoreUI.text = "Score: 0";
       scoreUI.GetComponent<TextGenerator>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void addScore()
    {
        score++;
        updateScoreText();
    }
    public void updateScoreText()
    {
        scoreUI.text = "Score: " + score.ToString();
    }
}
