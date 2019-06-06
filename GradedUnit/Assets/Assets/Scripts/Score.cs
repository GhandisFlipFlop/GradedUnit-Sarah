using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score : MonoBehaviour {

    //variable to track visible text score

    public Text scoreText;

    //variable to track numerical score

    private int numericalScore = 0;



	// Use this for initialization
	void Start ()
    {
        // Get the score from the Prefs database
        // Use a default 0 score if no score was saved
        // Store the result in numerical score variable

        numericalScore = PlayerPrefs.GetInt("score", 0);
        scoreText.text = numericalScore.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    //function to increase score
    public void AddScore(int _toAdd)
    {
        // Add the amount to the numerical score
        numericalScore = numericalScore + _toAdd;

        // Update the visual score
        scoreText.text = numericalScore.ToString();
    }

    // Function to save the score to the player preferences
    // Public so it can be triggered from another script (in this case Door)
    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", numericalScore);
    }

    public int GetScore()
    {
        return numericalScore;
    }

}
