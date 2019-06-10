using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

    public int scoreCount;
    public float hiScoreCount;

    public int pointsPerSecond;

    public bool scoreIncreasing;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HIGH SCORE") == true)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HIGH SCORE");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * (int)Time.deltaTime;
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HIGH SCORE", hiScoreCount);
        }

        scoreText.text = "ITEMS COLLECTED: " + scoreCount;
        hiScoreText.text = "HIGH SCORE: " + hiScoreCount;

    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }

    public int GetScore()
    {
        return scoreCount;
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", scoreCount);
    }
}
