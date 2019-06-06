using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// allows us to use scene management
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour {


    public void StartGame()
    {

        //Reset Life Counter//
        PlayerPrefs.DeleteKey("lives");


        //Reset the Score Counter//
        PlayerPrefs.DeleteKey("score");


        //Load the first Level//
        SceneManager.LoadScene("StartScreen");


    }
}
